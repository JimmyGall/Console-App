using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Microscopy
    {

        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Microscopy");

            Console.WriteLine("Size In CM: ");
            double sizeInCM = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Console.WriteLine("Magnification: ");
            double magnification = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Calculate(sizeInCM, magnification);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        public static void Calculate(double sizeInCM, double magnification)
        {

            double size = sizeInCM / magnification;

            Console.WriteLine("Magnification: " + size);
            Console.ReadKey();
        }
    }
}
