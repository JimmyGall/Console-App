using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CircleProperties
    {

        public static void properties(double diameter, double angle)
        {
            double radius = diameter / 2;
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = Math.PI * diameter;
            double arc_length = (circumference * angle) / 360;

            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Circumference: " + circumference);
            Console.WriteLine("Arc length: " + arc_length);

            Console.ReadKey();
        }

    }
}
