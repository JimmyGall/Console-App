using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Max
    {

        public static void Max(int first, int second)
        {
            if (first > second)
            {
                Console.WriteLine("The first number is greater: " + first);
            } else if (second > first)
            {
                Console.WriteLine("The second number is greater: " + second);
            } else if (first == second)
            {
                Console.WriteLine("Both numbers are equal");
            } else
            {
                Console.WriteLine("Error");
            }

            Console.ReadKey();
        }

    }
}
