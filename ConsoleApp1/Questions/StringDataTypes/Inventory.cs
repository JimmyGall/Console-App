using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringDataTypes
{
    internal class Inventory
    {

        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Inventory");

            Console.WriteLine("Enter items that you have in you inventory: ");
            string name = Console.ReadLine();

            CheckInventory(name.ToLower());

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static string[] GAME_ITEMS = { "shield", "potion", "charm", "bow" };

        static void CheckInventory(string item)
        {

            if (GAME_ITEMS.Contains(item))
            {
                Console.WriteLine($"{item} is a valid game item!");
            } else
            {
                Console.WriteLine($"{item} is an invalid game item!");
            }

            Console.ReadKey();
        }

    }
}
