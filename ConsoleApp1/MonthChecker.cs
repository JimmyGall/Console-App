using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MonthChecker
    {
        public static void ValidMonth(int Month)
        {
            if (Month >0 && Month <13)
            {
                Console.WriteLine(Month + " is a valid month.");
            } else
            {
                Console.WriteLine(Month + " is not a valid month.");
            }

            Console.ReadKey();
        }
    }
}
