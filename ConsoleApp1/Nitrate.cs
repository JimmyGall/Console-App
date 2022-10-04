using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Nitrate
    {

        public static double Dose()
        {
            Console.WriteLine("Is nitrate above 10?");
            if (Console.ReadLine() == "Yes".ToLower())
            {
                return 3;
            } else if (Console.ReadLine() == "No".ToLower())
            {

                Console.WriteLine("Is nitrate 2.5?");
                if ((Console.ReadLine() == "Yes".ToLower())) {
                    return 2;
                } else if ((Console.ReadLine() == "No".ToLower()))
                {

                    Console.WriteLine("Is nitrate above 1?");
                    if ((Console.ReadLine() == "Yes".ToLower()))
                    {
                        return 1;
                    } else if ((Console.ReadLine() == "No".ToLower()))
                    {
                        return 0.5;
                    }
                }
            }

            return 0;
        }
    }
}
