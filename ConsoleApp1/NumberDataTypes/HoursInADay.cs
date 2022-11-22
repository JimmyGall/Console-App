using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class HoursInADay
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Hours in a day");

            Console.WriteLine("Enter the hours: ");

            int hours = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            days(hours);

            Console.ReadKey();

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        public static double days(int hours)
        {
            double days = (double) hours / 24;

            Console.WriteLine("Days: " + days);
            return days;
        }

    }
}
