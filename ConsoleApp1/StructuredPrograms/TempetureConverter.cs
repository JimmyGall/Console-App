using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TempetureConverter
    {
        public static double enterValue()
        {
            Console.WriteLine("Valyue");

            //Add user to input values
            //Add it or each convertable

            string message = Console.ReadLine();
            return Double.Parse(message);
        }

        public static void ConvertToCentigrade()
        {
            double F = enterValue();

            double temp = (F - 32) / 1.8;

            Console.WriteLine("The temputure is " + temp + " Centigrade");
            Console.ReadKey();
        }

        public static void ConvertToFahrenheit(double C)
        {
            double temp = (C * 1.8) + 32;

            Console.WriteLine("The temputure is " + temp + " Fahrenheit");
            Console.ReadKey();
        }
    }
}
