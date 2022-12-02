using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConditionControlledIterations
{
    internal class CompoundInterest
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Compound Interest");

            Console.WriteLine("What is your current balance? ");
            double currentBalance = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Console.WriteLine("What are the current interest rates? ");
            int interestRate = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            Console.WriteLine("What is your desired balance? ");
            double desiredBalance = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Interest(currentBalance, interestRate, desiredBalance);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }


        static void Interest(double currentBalance, int interestRate, double desiredBalance)
        {
            double interestRateDouble = Convert.ToDouble(interestRate);

            double balance = currentBalance;

            interestRateDouble = interestRateDouble / 100.0;
            interestRateDouble += 1.0;

            for (int i = 0; balance < desiredBalance; i++)
            {
                balance = balance * interestRateDouble;

                Console.WriteLine($"Year: {i}, Current Balance: {String.Format("{0:0.00}", balance)}," +
                    $" Desired balance: {String.Format("{0:0.00}", desiredBalance)}," +
                    $" Interest rate: {String.Format("{0:0.00}", interestRate)}%");
            }

            Console.ReadKey();
        }
    }
}
