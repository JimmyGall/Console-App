using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SaveTheChange
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Periodic Table");

            Console.WriteLine("Enter an amount of money: ");

            double price = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

            Change(price);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        public static void Change(double Price)
        {
            double NearestPound = Convert.ToInt32(Price);

            double Diffrence = NearestPound - Price;

            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Diffrence: " + Diffrence);

            Console.ReadKey();
        }

    }
}
