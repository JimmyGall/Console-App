using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Characters
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Characters");

            convert();

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        public static void convert()
        {
            Console.WriteLine("Please enter numbers between 0-9");

            string message = Console.ReadLine();
            Console.WriteLine("\nMessage: " + message);

            string newMessage = message
                .Replace('0', 'a')
                .Replace('1', 'b')
                .Replace('2', 'c')
                .Replace('3', 'd')
                .Replace('4', 'A')
                .Replace('5', 'B')
                .Replace('6', 'C')
                .Replace('7', 'D')
                .Replace('8', '@')
                .Replace('9', '#');


            Console.WriteLine("Convert: " + newMessage);
            Console.ReadKey();
        }
    }
}
