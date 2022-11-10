FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /App

# Copy everything 代表會將本機端同一層的所有檔案加到 Linux 的 /app 目錄底下
COPY . ./
# Restore as distinct layers 執行dotnet restore，將相依的檔案下載下來
RUN dotnet restore
# Build and publish a release Publish目前的專案
RUN dotnet publish -c Release -o out

# Build runtime image 建立 runtime 的 Image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /App
# 將 build 好的專案複製到 /app/out 目錄底下
COPY --from=build-env /App/out .
# 設定進入點為 DotNet.Docker.First.dll
ENTRYPOINT ["dotnet", "DotNet.Docker.First.dll"]