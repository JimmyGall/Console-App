using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ballpit
    {

        public static void Calculate(double Ballpit_height, double Ballpit_radius, double ball_radius)
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
