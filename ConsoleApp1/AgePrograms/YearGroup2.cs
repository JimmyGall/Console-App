using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AgePrograms
{
    internal class YearGroup2
    {
        public static void YearGroup(int Year)
        {
            Console.WriteLine("Switch-Case statement example:");
            Console.WriteLine("Input year: " + Year);

            switch (Year)
            {
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Key Stage 3");
                    break;

                case 10:
                case 11:
                    Console.WriteLine("Key Stage 4");
                    break;
            }

            Console.ReadKey();
        }
    }
}
