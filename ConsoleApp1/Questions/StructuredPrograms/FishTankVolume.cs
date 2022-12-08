using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FishTankVolume
    {

        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Fish Tank Volume");

            Console.WriteLine("Fish tank length: ");
            double length = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Console.WriteLine("Fish tank depth: ");
            double depth = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Console.WriteLine("Fish tank height: ");
            double height = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Volume(length, depth, height);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void Volume(double length, double depth, double height)
        {

            double volume = (length * depth * height) / 1000;
            Console.WriteLine("The amount of litres for the fish tank: " + volume);
            Console.ReadKey();
        }
    }
}
