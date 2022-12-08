using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            nameSplitter(name);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void nameSplitter(string name)
        {
            var r = new Regex(@"(?<=[A-Z])(?=[A-Z][a-z]) |(?<=[^A-Z])(?=[A-Z]) |(?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);

            Console.WriteLine("{0}", r.Replace(name, " "));
            Console.ReadKey();
        }
    }
}
