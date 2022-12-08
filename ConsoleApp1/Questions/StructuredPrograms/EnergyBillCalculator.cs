using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EnergyBillCalculator
    {

        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Energy Bill Calculator");

            Console.WriteLine("Preivous meter reading: ");
            double preivousMeter = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Console.WriteLine("Current meter reading: ");
            double currentReading = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Console.WriteLine("Calorific value: ");
            double calorificValue = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Calculate(preivousMeter, currentReading, calorificValue);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);

        }

        static void Calculate(double preivousMeter, double currentReading, double calorificValue)
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
