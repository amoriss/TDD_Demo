using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Demo;
public class Methods
{
    public int Add(int number1, int number2)
    {
        return number1 + number2;
    }

    public static string GetGreeting()
    {
        return "Hello!";
    }

    public int AddArray(int[] arr)
    {
        if (arr == null)
        {
            return 0;
        }
        return arr.Sum();
    }
}
