using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConsoleCommands
{
    internal class HelpCommand
    {

        public static void Execute()
        {
            Console.Clear();
            ProgramMethods.ProgramMethods.ProgramTitle("Help menu");


            Console.WriteLine("Available commands:                                                  \n" +
                              " help - Displays this help message                                   \n" +
                              " exit - Exits the program. (Alternatives: 'e', 'terminate' or 'off') \n" +
                              " FPrint - Example of printing a better print.                        \n" +
                              " settings - shows the settings menu.                                 \n" +
                              "");

            Console.WriteLine("Fun stuff to try out:                                                \n" +
                              " crack password - A program that times how long it takes for a computer to guess your passcode. \n" +
                              " disco - Makes the program go disco mode, re-enter command to stop.");

            ConsoleCommands.ConsoleCommandManager.Command(Console.ReadLine());
        }
    }
}
