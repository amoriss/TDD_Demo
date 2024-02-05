using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Demo;
public class SalaryCalculator
{
    public static double CalculateHourlyWage(double annualSalary)
    {
        const int workHoursPerWeek = 40;
        const int weeksPerYear = 52;
        return annualSalary / (workHoursPerWeek * weeksPerYear);
    }
}
