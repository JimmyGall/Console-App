using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Max
    {

        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Max");

            Console.WriteLine("First number: ");
            int first = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            Console.WriteLine("Second number: ");
            int second = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            Max_Challenge(first, second);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void Max_Challenge (int first, int second)
        {
            if (first > second)
            {
                Console.WriteLine("The first number is greater: " + first);
            } else if (second > first)
            {
                Console.WriteLine("The second number is greater: " + second);
            } else if (first == second)
            {
                Console.WriteLine("Both numbers are equal");
            } else
            {
                Console.WriteLine("Error");
            }

            Console.ReadKey();
        }

    }
}
