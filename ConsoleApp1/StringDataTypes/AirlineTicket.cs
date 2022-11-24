using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringDataTypes
{
    internal class AirlineTicket
    {

        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Airline ticket");

            Console.WriteLine("Enter the location of which your plane is departing from: ");
            string departing = Console.ReadLine();

            Console.WriteLine("Enter the location of which your plane is ariving to: ");
            string ariving = Console.ReadLine();

            location(departing, ariving);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void location(string departing, string ariving)
        {
            string DEPARTING_SHORT = departing.Substring(0, 4);
            string ARIVING_SHORT = ariving.Substring(0, 4);

            Console.WriteLine($"This arline service is {DEPARTING_SHORT.ToUpper()}-{ARIVING_SHORT.ToUpper()}");

            Console.ReadKey();
        }

    }
}
