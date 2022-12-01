using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CounterControlledIterations
{
    internal class PrimeNumber
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Prime Number");

            Console.WriteLine("Enter your number ");
            int number = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            Console.WriteLine($"Is {number} a prime? {isPrime(number)}");
            Console.ReadKey();

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number));

            for (int i = 2; i <= limit; ++i)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
