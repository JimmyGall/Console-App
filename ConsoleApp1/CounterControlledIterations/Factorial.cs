using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CounterControlledIterations
{
    internal class Factorial
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Factorial");

            Console.WriteLine("What number would you like to see? ");
            int number = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            FactorialCalculation(number);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void FactorialCalculation(int number)
        {
            int total = 1;

            string message = "";

            for (int y = 1; y < number+1; y++)
            {
                message += y;
                total *= y;

            }

            Console.WriteLine($"Timesing: {message}");
            Console.WriteLine($"Total: {total}");
            Console.ReadKey();
        }
    }
}
