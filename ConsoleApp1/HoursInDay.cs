using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class HoursInDay
    {

        public static double days(int hours)
        {
            double days = hours / 24;

            Console.WriteLine("Days: " + days);
            return days;
        }

    }
}
