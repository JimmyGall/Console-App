using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Divisible
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Divisible");

            Console.WriteLine("Enter the first value: ");
            double value1 = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());


            Console.WriteLine("Enter the second value: ");
            double value2 = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Console.WriteLine($"Are the 2 values entered divisable? : {divisable(value1, value2)}");
            Console.ReadKey();

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        public static bool divisable(double value1, double value2)
        {
            if ((value1 / value2) != 0)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
