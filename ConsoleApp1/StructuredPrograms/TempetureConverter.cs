using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TempetureConverter
    {

        public static void ConvertToCentigrade(double F)
        {
            double temp = (F - 32) / 1.8;

            Console.WriteLine("The temputure is " + temp + " Centigrade");
            Console.ReadKey();
        }

        public static double ConvertToFahrenheit(double C)
        {
            double temp = (C * 1.8) + 32;

            Console.WriteLine("The temputure is " + temp + " Fahrenheit");
            //Console.ReadKey();
            return temp;
        }
    }
}
