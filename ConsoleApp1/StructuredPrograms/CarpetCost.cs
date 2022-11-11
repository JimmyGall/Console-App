using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CarpetCost
    {

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
