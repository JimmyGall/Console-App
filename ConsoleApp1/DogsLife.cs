using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DogsLife
    {
        public static void dog_life(int years)
        {

            if (years <= 2)
            {
                Console.WriteLine("Years: " + years);
                Console.WriteLine("Dog years: " + years * 12);

            } else if (years > 2)
            {
                Console.WriteLine("Years: " + years);
                int dog_years = (24 + years * 6) - 2;
                Console.WriteLine("Dog years: " + dog_years);
            }
            Console.ReadKey();
        }
    }
}
