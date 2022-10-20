using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PeriodicTable
    {
        public static void element()
        {
            Console.WriteLine("Please enter an element:");

            string value = Console.ReadLine();

            Console.WriteLine(ReturnElementName(value));
            Console.ReadKey();
        }

        public static string ReturnElementName(string name)
        {
            switch(name)
            {
                case "H":
                    return "Element: Hydrogen \nAtomic weight: 1.0078 \nGroup: Reactive nonmetals";

                case "He":
                    return "Element: Helium \nAtomic weight: 4.0026 \nGroup: Noble gases";

                case "Li":
                    return "Element: Lithium \nAtomic weight: 6.9410 \nGroup: Alkali metals";

            }
            return null;
        }
    }
}
