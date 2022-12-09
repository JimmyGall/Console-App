using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Questions.ConditionControlledIterations
{
    internal class DenaryToBinary
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Denary To Binary");

            Console.WriteLine("Enter a number: ");
            int number = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            convert(number);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void convert(int number)
        {
            int newNumber = number;

            List<Int32> binary = new List<Int32>();

            do
            {
                newNumber = newNumber / 2;

                if (newNumber % 2 >= 1)
                {
                    binary.Add(1);
                }
                else
                {
                    binary.Add(0);
                }

            } while (newNumber != 0);

            string message = "";

            for (int i = 0; i < binary.Count; i++)
            {
                message += $"{binary[i]}";
            }

            Console.WriteLine("Your binary: " + message);

            Console.ReadKey();
        }
    }
}
