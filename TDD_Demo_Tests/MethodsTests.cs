using TDD_Demo;

namespace TDD_Demo_Tests;


public class MethodsTests
{
    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(3, 1, 4)]
    [InlineData(-1, -1, -2)]
    public void AddTest(int num1, int num2, int expected)
    {
        //Arrange
        Methods instance = new Methods();

        //Act
        int actual = instance.Add(num1, num2);

        //Assert
        Assert.Equal(expected, actual);

    }


    [Fact]
    public void GetGreetingTest()
    {
        //Arrange 

        //Act
        var actual = Methods.GetGreeting();

        //Assert
        Assert.Equal("Hello!", actual);

    }
}