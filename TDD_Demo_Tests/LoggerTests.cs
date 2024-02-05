using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_Demo;

namespace TDD_Demo_Tests;
public class LoggerTests
{
    [Fact]
    public void LogMessage_AddsMessageToLog()
    {
        // Arrange
        var logger = new Logger();
        var message = "Test message";

        // Act
        logger.LogMessage(message);

        // Assert
        var loggedMessages = logger.GetLoggedMessages();
        Assert.Contains(message, loggedMessages);
    }

    [Theory]
    [InlineData("First message")]
    [InlineData("")]
    [InlineData(null)]
    public void LogMessage_HandlesDifferentMessageTypes(string message)
    {
        // Arrange
        var logger = new Logger();

        // Act
        logger.LogMessage(message);

        // Assert
        var loggedMessages = logger.GetLoggedMessages();
        Assert.Contains(message, loggedMessages);
    }
}
