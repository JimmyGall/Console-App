using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConsoleCommands
{
    internal class SettingsCommand
    {
        public static void Execute()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Settings");

            Console.Clear();

            ConsoleCommands.ConsoleCommandManager.Command(Console.ReadLine());
        }
    }
}
