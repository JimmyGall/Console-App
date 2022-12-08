using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CarpetCost
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Carpet Cost");

            Console.WriteLine("Carpet width (Meters): ");
            double width = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Console.WriteLine("Carpet length (Meters): ");
            double length = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Console.WriteLine("Price per m2: ");
            double pricePerM = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Cost(width, length, pricePerM);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        public static void Cost(double width, double length, double pricePerM)
        {
            double totalSize = width * length;

            double cost;

            double underlay = totalSize * 3;
            double carpetFitting = totalSize * pricePerM;
            double grippers = width * 2 + length * 2;


            cost = underlay + grippers + carpetFitting + 50;

            Console.WriteLine("Total carpet cost = " + cost);
            Console.ReadKey();
        }
    }
}
