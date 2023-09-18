using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Demo;
public class Clock
{
    public int GetCurrentHour()
    {
        return DateTime.Now.Hour;
    }
}
