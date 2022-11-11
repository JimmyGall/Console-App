using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Microscopy
    {
        public static void Calculate(double sizeInCM, double magnification)
        {

            double size = sizeInCM / magnification;

            Console.WriteLine("Magnification: " + size);
            Console.ReadKey();
        }
    }
}
