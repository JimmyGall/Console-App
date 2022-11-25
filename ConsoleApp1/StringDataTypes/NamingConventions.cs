using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1.StringDataTypes
{
    internal class NamingConventions
    {

        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Naming conventions");

            Console.WriteLine("Enter your sentence: ");
            string message = Console.ReadLine();

            CaseConvertor(message);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void CaseConvertor(string message)
        {
            string kebab_case = message.Replace(" ", "-");
            string snake_case = message.Replace(" ", "_");

            string camel_case = NamingConventions.PascalCase(message);

            string pascal_case = Regex.Replace(message.ToLower(), @"(^\w)|(\s\w)", m => m.Value.ToUpper()).Replace(" ", "");

            Console.WriteLine($"Kebab case: {kebab_case} \n" +
                              $"Snake case: {snake_case} \n" +
                              $"Camel case: {camel_case} \n" +
                              $"Pascal case: {pascal_case} ");

            Console.ReadKey();
        }

        static string PascalCase(string str)
        {
            TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
            str = Regex.Replace(str, "([A-Z]+)", " $1");
            str = cultInfo.ToTitleCase(str);
            str = str.Replace(" ", "");
            return str;
        }
    }
}
