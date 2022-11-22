﻿using System;
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
                              " FPrint - Example of printing a better print.");

            ConsoleCommands.ConsoleCommandManager.Command(Console.ReadLine());
        }
    }
}