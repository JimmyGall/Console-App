using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DrivingTest
    {

        public static void Test(int fualts)
        {
            if (fualts >= 15)
            {
                Console.WriteLine("Failed");
            } else
            {
                Console.WriteLine("Passed");
            }

            Console.ReadKey();
        }

    }
}
