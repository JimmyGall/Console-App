using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DayFormat
    {
        public static void format()
        {
            Console.WriteLine("What day is it today? \nOptions: monday, tuesday, wednesday, thursday, friday, sataruday, sunday");

            switch(Console.ReadLine().ToLower())
            {
                case "monday":
                    Console.WriteLine("Day: Monday");
                    Console.WriteLine("Shortday: Mon");
                    Console.WriteLine("Char: M");
                    break;

                case "tuesday":
                    Console.WriteLine("Day: Tuesday");
                    Console.WriteLine("Shortday: Tue");
                    Console.WriteLine("Char: Tu");
                    break;

                case "wednesday":
                    Console.WriteLine("Day: Wednesday");
                    Console.WriteLine("Shortday: Wed");
                    Console.WriteLine("Char: W");
                    break;

                case "thursday":
                    Console.WriteLine("Day: Thursday");
                    Console.WriteLine("Shortday: Thu");
                    Console.WriteLine("Char: Th");
                    break;

                case "friday":
                    Console.WriteLine("Day: Friday");
                    Console.WriteLine("Shortday: Fri");
                    Console.WriteLine("Char: F");
                    break;

                case "sataruday":
                    Console.WriteLine("Day: Sataruday");
                    Console.WriteLine("Shortday: Sat");
                    Console.WriteLine("Char: Sa");
                    break;

                case "sunday":
                    Console.WriteLine("Day: Sunday");
                    Console.WriteLine("Shortday: Sun");
                    Console.WriteLine("Char: Su");
                    break;

                default:
                    Console.WriteLine("Error: Invalid input.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
