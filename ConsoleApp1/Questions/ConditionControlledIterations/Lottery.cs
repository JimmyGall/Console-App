using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConditionControlledIterations
{
    internal class Lottery
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Discount Counter");

            Console.WriteLine("Number must be between the values 0 and 30");

            Console.WriteLine("What is your first number? ");
            int num1 = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            Console.WriteLine("What is your second number? ");
            int num2 = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            Console.WriteLine("What is your third number? ");
            int num3 = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());


            LotteryNumbers(num1, num2, num3);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void LotteryNumbers(int num1, int num2, int num3)
        {
            Random random = new Random();

            int randomNum1 = random.Next(0, 30);
            int randomNum2 = random.Next(0, 30);
            int randomNum3 = random.Next(0, 30);

            for (int weeks = 0; !((randomNum1 == num1) && (randomNum2 == num2) && (randomNum3 == num3)); weeks++)
            {
                Console.WriteLine($"Week {weeks}: Numbers: {randomNum1}, {randomNum2} and {randomNum3}. You put {num1}, {num2} and {num3}");

                randomNum1 = random.Next(0, 30);
                randomNum2 = random.Next(0, 30);
                randomNum3 = random.Next(0, 30);
            }


            Console.WriteLine($"Lottery won! Numbers: {randomNum1}, {randomNum2} and {randomNum3}. You put {num1}, {num2} and {num3}");
            Console.ReadKey();
        }
    }
}
