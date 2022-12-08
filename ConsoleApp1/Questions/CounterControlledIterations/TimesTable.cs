using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CounterControlledIterations
{
    internal class TimesTable
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Times table");

            Console.WriteLine("What times table would you like to see? ");
            int number = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            times(number);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void times(int x)
        {
            Console.WriteLine($"The {x} times table!\n");

            for (int y = 0; y < 13; y++)
            {
                int answer = y * x;

                Console.WriteLine($"{y} times {x} is {answer}");
            }

            Console.ReadKey();
        }
    }
}
