namespace csharp_assignment_hello_world.Tests;
using Xunit;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Act
        var result = Program.SayHello();

        // Assert
        Assert.Equal("Hello World!", result);
    }
}
