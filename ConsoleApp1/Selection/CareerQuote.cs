using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CareerQuote
    {

        public static void Job(string Job)
        {
            if (Job == "Engineer")
            {
                Console.WriteLine("The engineer has been, and is, a maker of history.");
            } else if (Job == "Developer")
            {
                Console.WriteLine("Logical thinking, passion and perseverance is the paint of your palette.");

            } else if (Job == "Analyst")
            {

                Console.WriteLine("Seeing what other people can't see gives you great vision");
            } else
            {
                Console.WriteLine("I'm sorry, We could not find a quote for your job.");
            }

            Console.ReadKey();
        }

    }
}
