using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CarValue
    {

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
    }
}
