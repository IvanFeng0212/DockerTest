namespace DotNet.Docker.NUnitTest;

[TestFixture]
public class Tests
{
    [Test]
    public void Test1()
    {
        // Arrange
        using (var sw = new StringWriter()) 
        {
            Console.SetOut(sw);

            // Act
            DotNet.Docker.First.Program.Main();

            var res = sw.ToString().Trim();

            // Assert
            Assert.That(res, Is.EqualTo("Hello World!"));
        }
    }
}