using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConditionControlledIterations
{
    internal class DiscountCounter
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Discount Counter");

            IncreaseSalePercentage();

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void IncreaseSalePercentage()
        {
            Random random = new Random();

            int sale = 0;

            for (;;)
            {
                int randomValue = random.Next(0, 20);

                if (sale <= 60)
                {
                    sale += randomValue;
                } else
                {
                    sale = 60;
                    Console.WriteLine("Sale went over the limit! Its now 60");
                    break;
                }

                Console.WriteLine($"The current sale is: {sale}");
            }

            Console.WriteLine($"Sale is: {sale}");

            Console.ReadKey();
        }

    }
}
