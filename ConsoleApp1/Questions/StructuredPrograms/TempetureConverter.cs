using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TempetureConverter
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Tempeture Converter");

            TempetureConverter.ConvertToFahrenheit();
            TempetureConverter.ConvertToCentigrade();

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        public static void ConvertToCentigrade()
        {
            Console.WriteLine("Convert to Centigrade from Fahrenheit...");

            double F = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());
            double temp = (F - 32) / 1.8;
            
            Console.WriteLine("The temputure is " + temp + " Centigrade");
            Console.ReadKey();
        }

        public static void ConvertToFahrenheit()
        {
            Console.WriteLine("Convert to Fahrenheit from Centigrade...");

            double C = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());
            double temp = (C * 1.8) + 32;

            Console.WriteLine("The temputure is " + temp + " Fahrenheit");
        }
    }
}
