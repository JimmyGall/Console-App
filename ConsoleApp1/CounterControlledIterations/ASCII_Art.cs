using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CounterControlledIterations
{
    internal class ASCII_Art
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: ASCII Art");

            Console.WriteLine("Enter your message: ");
            string message = Console.ReadLine();

            PrintASCIIArt(message);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void PrintASCIIArt(string message)
        {
            //ASCII Art code
            char[] message_characters = message.ToArray();
            string message_characters_art = "|";

            for (int i = 0; i < message_characters.Length; i++)
            {
                message_characters_art = message_characters_art + $"{message_characters[i]}|";
            }

            char[] art_characters = message_characters_art.ToArray();


            //Border code
            string border = "+";

            for (int i = 0; i < art_characters.Length; i++)
            {
                char[] border_characters = border.ToArray();

                if (border_characters[i] == '+')
                {
                    border = border + "-";
                }
                else
                {
                    border = border + "+";
                }
            }

            string final_message = $"{border}\n{message_characters_art.ToUpperInvariant()}\n{border}";

            Console.WriteLine(final_message);
            Console.ReadKey();
        }
    }
}
