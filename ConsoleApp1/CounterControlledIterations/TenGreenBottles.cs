using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CounterControlledIterations
{
    internal class TenGreenBottles
    {

        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Ten Green Bottles");

            song();

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void song()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"{i} green bottles on the wall,                  \n" +
                                  $"{i} green bottles on the wall,                  \n" +
                                  $"And if one green bottle should accidently fall  \n" +
                                  $"There'll be {i-1} bottles hanging on the wall \n\n" +
                                  $"..................................................");
            }

            Console.ReadKey();
        }

    }
}
