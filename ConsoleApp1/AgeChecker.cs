using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AgeChecker
    {
        public static void Age()
        {

            Console.WriteLine("What is your age?");

            if (Convert.ToInt64(Console.ReadLine()) >= 17)
            {
                Console.WriteLine("You are old enough to learn to drive.");
            }
            else
            {
                Console.WriteLine("You are not old enough to learn to drive.");
            }

            Console.ReadKey();
        }
    }
}
