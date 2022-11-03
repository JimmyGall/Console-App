using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CompundInterest
    {
        public static void interest(double startingCash, double years)
        {
            Console.WriteLine("Starting cash: " + startingCash);
            Console.WriteLine("Amount of years: " + years);

            double cash = startingCash;

            for (int i = 0; i < years; i++)
            {
                cash *= ((years / 100) + 1);
            }
            Console.WriteLine("Years: " + years + " \nStarting Cash: " + startingCash + " \nInterest %: " + (years / 100) + " \nInterest: " + cash);
            Console.ReadKey();

        }
    }
}
