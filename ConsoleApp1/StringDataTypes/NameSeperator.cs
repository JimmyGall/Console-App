using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringDataTypes
{
    internal class NameSeperator
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Name seperator");

            Console.WriteLine("Enter your full name: ");
            string name = Console.ReadLine();

            valid_email(email);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void nameSplitter(string name)
        {
            Regex.Split(name, @"(?<!^)(?=[A-Z])");
        }
    }
}
