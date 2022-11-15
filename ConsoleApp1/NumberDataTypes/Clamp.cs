using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Clamp
    {
        public static void Clamp_Challenge(int value, int min, int max)
        {
            if (min <= value && value <= max)
            {
                Console.WriteLine("Value: " + value);
            }
            if (value < min)
            {
                Console.WriteLine("Min: " + min);
            }
            if (value > max)
            {
                Console.WriteLine("Max: " + max);
            }

            Console.ReadKey();
        }
    }
}
