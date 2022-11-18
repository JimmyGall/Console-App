using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ballpit
    {

        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Ballpit");

            Console.WriteLine("Ballpit Height: ");
            double Ballpit_height = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Console.WriteLine("Ballpit radius: ");
            double Ballpit_radius = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Console.WriteLine("Ball radius: ");
            double ball_radius = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Calculate(Ballpit_height, Ballpit_radius, ball_radius);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }
        static void Calculate(double Ballpit_height, double Ballpit_radius, double ball_radius)
        {
            double packingDensity = 0.75;

            double ballpit_Volume = Math.PI * Math.Pow(Ballpit_radius, 2) * Ballpit_height;
            double ball_Volume = (4 / 3) * Math.PI * Math.Pow(ball_radius, 3);

            double total = ballpit_Volume / ball_Volume * packingDensity;

            Console.WriteLine("Total: " + total);
            Console.ReadKey();

        }

    }
}
