using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FishTank
    {

        public static void Volume(double length, double depth, double height)
        {
            double volume = (length * depth * height) / 1000;
            Console.WriteLine("The amount of litres for the fish tank: " + volume);
            Console.ReadKey();
        }

    }
}
