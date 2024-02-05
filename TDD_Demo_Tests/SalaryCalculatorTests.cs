using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_Demo;

namespace TDD_Demo_Tests;
public class SalaryCalculatorTests
{
    [Theory]
    [InlineData(52000, 25)] // $52,000 annual salary should result in $25 per hour
    [InlineData(104000, 50)] // $104,000 annual salary should result in $50 per hour
    [InlineData(0, 0)] // $0 annual salary should result in $0 per hour
    public void CalculateHourlyWageTest(double annualSalary, double expectedHourlyWage)
    {
        // Act
        double hourlyWage = SalaryCalculator.CalculateHourlyWage(annualSalary);

        // Assert
        Assert.Equal(expectedHourlyWage, hourlyWage, 2); // Using a precision of 2 decimal places
    }
}
