using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CarValue
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Car Value");

            Console.WriteLine("What is the current year? ");
            int year = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            Console.WriteLine("What was the price you got the car at? ");
            double carValue = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Console.WriteLine("What is the car's mininum resell value? ");
            double minResellValue = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            value(year, carValue, minResellValue);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void value(int year, double carValue, double minResellValue)
        {

            double currentCarValue = carValue;

            year = DateTime.Now.Year;

            for (int i = 0; currentCarValue > minResellValue; i++)
            {
                if (i <= 2)
                {
                    currentCarValue *= 0.70;
                } else
                {
                    currentCarValue *= 0.80;
                }

                year += i;

                Console.WriteLine($"After {i} years, the car value will be at: {currentCarValue}");
            }

            Console.WriteLine($"In {year}, the car value will fall to its min resell value.");
            Console.ReadKey();
        }

        /*
        public static void Value(int year, double carValue, double minResaleValue)
        {
            if (year > 1) ;
            year--;

            carValue *= 0.70;

            if (carValue > minResaleValue) ;

            for (int i = year; i < year; i++)
            {
                if (carValue > minResaleValue) ;
                carValue *= 0.80;
                Console.WriteLine("Year " + year + ", Value: " + carValue);
            }

            Console.ReadKey();
        }
        */
    }
}
