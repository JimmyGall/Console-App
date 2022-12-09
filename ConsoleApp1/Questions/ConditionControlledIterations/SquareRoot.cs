using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Questions.ConditionControlledIterations
{
    internal class SquareRoot
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Square Root");

            Console.WriteLine("Enter a number to be square rooted. ");
            double number = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            root(number);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void root(double x)
        {

            double root = x;
            double previousNumber = 0;

            do
            {
                previousNumber = root;
                root = 0.5 * (root + (x / root));

                Console.WriteLine($"The current number is: {root}");

            } while (root != previousNumber);

            Console.WriteLine($"Final number: {root}");
            Console.ReadKey();
        }
    }
}
