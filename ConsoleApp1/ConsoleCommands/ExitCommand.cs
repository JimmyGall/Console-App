using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConsoleCommands
{
    internal class ExitCommand
    {

        public static void Execute()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Exited!");

            Console.WriteLine("Program terminated! Press the return key to close the application.");
            Console.ReadKey();
        }

    }
}
