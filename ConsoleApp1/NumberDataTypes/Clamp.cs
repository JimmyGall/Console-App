using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Clamp
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Clamp");

            Console.WriteLine("Enter the value: ");
            int value = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            Console.WriteLine("Enter the min value: ");
            int min = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            Console.WriteLine("Enter the max value: ");
            int max = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            Clamp_Challenge(value, min, max);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        public static void Clamp_Challenge(int value, int min, int max)
        {
            if (min <= value && value <= max)
            {
                Console.WriteLine("Value: " + value);
            }
            if (value < min)
            {
                Console.WriteLine("Min: " + min);
            }
            if (value > max)
            {
                Console.WriteLine("Max: " + max);
            }

            Console.ReadKey();
        }
    }
}
