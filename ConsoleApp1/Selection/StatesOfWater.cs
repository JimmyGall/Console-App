using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StatesOfWater
    {

        public static void Status(int status)
        {
            if (status >= 100)
            {
                Console.WriteLine("Gaseous");
            } else if (status >= 1 && status <= 99)
            {
                Console.WriteLine("Liquid");
            } else if (status <= 0)
            {
                Console.WriteLine("Solid");
            }
        }

    }
}
