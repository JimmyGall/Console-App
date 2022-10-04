using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Microscope
    {
        public static void Calculate(double sizeInCM, double micrometers)
        {
            double size = micrometers / sizeInCM;

            Console.WriteLine("Size: " + size);
            Console.ReadKey();
        }
    }
}
