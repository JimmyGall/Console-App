using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EnergyBillCalculator
    {

        public static void Calcualte(double preivousMeter, double currentReading, double calorificValue)
        {
            double unitsUsed = currentReading - preivousMeter;

            double kWh = unitsUsed * 1.022 * calorificValue / 3.6;
            double cost = kWh * 2.84;

            Console.WriteLine("kWh: " + kWh);
            Console.WriteLine("Cost: " + cost);
            Console.ReadKey();
        }
    }
}
