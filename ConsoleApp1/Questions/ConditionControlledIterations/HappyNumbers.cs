using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Questions.ConditionControlledIterations
{
    internal class HappyNumbers
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Happy Numbers");

            Console.WriteLine("PROGRAM TAKEN FROM WEBSITE AND SLIGHTLY MODIFIED, ALL CREDITS TO GARETH ADAMS.");

            Console.WriteLine("Enter a number: ");
            int number = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            isNumberHappy(number);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void isNumberHappy(int number)
        {
            bool Completed = false;
            string newString;
            int IDigit;
            int Total;

            do
            {
                newString = Convert.ToString(number);
                Total = 0;

                for (int Digit = 0; Digit < newString.Length; Digit++)
                {
                    IDigit = Convert.ToInt32(Convert.ToString(newString[Digit]));
                    if (IDigit == 4)
                    {
                        Completed = true;
                        Console.WriteLine($"Number {number} is a sad number!");
                    }
                    Total += (IDigit * IDigit);
                }
                number = Total;
                if (number == 1)
                {
                    Completed = true;
                    Console.WriteLine($"Number {number} is a happy number!");
                }

            } while (!Completed);

            Console.ReadKey();
        }
    }
}
