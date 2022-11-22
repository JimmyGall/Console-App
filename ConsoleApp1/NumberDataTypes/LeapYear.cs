using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LeapYear
    {

        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Leap year");

            Console.WriteLine("Enter the year: ");

            int year = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            Year(year);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        public static void Year(int year)
        {
            if (((year % 4 == 0) && (year % 100 != 0)) || year % 400 == 0)
            {
                Console.WriteLine(year + " is a leap year");
            } else
            {
                Console.WriteLine(year + " is not a leap year");
            }

            Console.ReadKey();
        }
    }
}
