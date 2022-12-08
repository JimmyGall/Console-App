using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CircleProperties
    {

        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Circle Properties");

            Console.WriteLine("Circle Diameter: ");
            double diameter = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Console.WriteLine("Circle angle: ");
            double angle = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            properties(diameter, angle);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void properties(double diameter, double angle)
        {
            double radius = diameter / 2;
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = Math.PI * diameter;
            double arc_length = (circumference * angle) / 360;

            Console.WriteLine("\nRadius: " + radius);
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Circumference: " + circumference);
            Console.WriteLine("Arc length: " + arc_length);

            Console.ReadKey();
        }

    }
}
