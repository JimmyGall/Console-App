using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AgePrograms
{
    internal class YearGroup1
    {
        public static void YearGroup(int Year)
        {
            Console.WriteLine("If-else statement example:");
            Console.WriteLine("Input year: " + Year);

            if (Year >= 7 && Year < 12)
            {
                Console.WriteLine("Key Stage 3");
            } else if (Year >= 10 && Year < 12)
            {
                Console.WriteLine("Key Stage 4");
            }

            Console.ReadKey();
        }
    }
}
