using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Loop
    {

        public static void whileLoop()
        {
            string item_required;
            item_required = Console.ReadLine();

            while (item_required.Length == 0)
            {
                Console.WriteLine("Item Required: ");
                item_required = Console.ReadLine();
            }

            Console.ReadLine();
        }

        public static void arrayLoop(string item_required)
        {
            string[] location = new string[11] { "010101", "010102", "010103", "010104", "010105", "010106", "010107", "010108", "010109", "010110", "010111" };
            string[] item_code = new string[11] { "929194", "929186", "514832", "550015", "0", "0", "0458961", "478591", "0", "514832", "514832" };
            string item_location;

            for (int i = 0; i < 11; i++)
            {
                if (item_code[i] == item_required)
                {
                    item_location = location[i];

                    Console.WriteLine("Item found");
                    Console.WriteLine("Bay: " + item_location.Substring(0, 2));
                    Console.WriteLine("Shelf: " + item_location.Substring(2, 2));
                    Console.WriteLine("Selection: " + item_location.Substring(2, 4));
                    Console.ReadKey();


                }
            }
        }
    }
}
