using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_Demo;

namespace TDD_Demo_Tests;
public class ClockTests
{
    [Fact]
    public void GetCurrentHour_ReturnsValidHour()
    {
        // Arrange
        var clock = new Clock();

        // Act
        var result = clock.GetCurrentHour();

        // Assert
        //bool isHourInRange = result >= 0 && result <= 23;
        //Assert.True(isHourInRange, $"Expected hour to be between 0 and 23, but was {result}.");

        Assert.InRange(result, 0, 23);
    }
}
