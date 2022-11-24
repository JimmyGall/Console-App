using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringDataTypes
{
    internal class Initial_Surname
    {

        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Initial & Surname");

            Console.WriteLine("Please enter your Initial and Surname: ");
            string name = Console.ReadLine();

            Name(name);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void Name(string name)
        {

            string firstNameCharacter = name.Substring(0, 1);

            string removed_name = string.Join(" ", name.Split().Skip(1));

            string new_name = $"{firstNameCharacter.ToUpper()} {removed_name.ToUpper()}";

            new_name.ToUpper();

            Console.WriteLine($"Name entered: {name}");
            Console.WriteLine($"New Name: {new_name}");


            Console.ReadKey();
        }

    }
}
