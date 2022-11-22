using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConsoleCommands
{
    internal class FPrintCommand
    {
        public static void Execute()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Command: FPrint");

            string[] names = { "Andrew", "Bob", "Patrick", "John" };

            Console.WriteLine("{0} is a cool name!", names[1]);

            Console.WriteLine($"{names[1]} is a cool name!");

            Console.ReadKey();

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }
    }
}
