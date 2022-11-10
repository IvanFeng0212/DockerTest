namespace DotNet.Docker.MSTest;

[TestClass]
public class MSTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        // Arrange
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);

            // Act
            DotNet.Docker.First.Program.Main();

            var res = sw.ToString().Trim();

            // Assert
            Assert.AreEqual("Hello World!", res);
        }
    }
}