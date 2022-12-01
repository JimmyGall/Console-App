using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CounterControlledIterations
{
    internal class Passcode
    {

        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Passcode");

            Console.WriteLine("Enter your word ");
            string word = Console.ReadLine();

            returnPassword(word);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void returnPassword(string word)
        {
            List<int> passcode = new List<int>();

            char[] accepted = { 'A', 'E', 'I', 'O', 'U' };

            char[] word_characters = word.ToUpperInvariant().ToArray();

            for (int i = 0; i < word_characters.Length; i++)
            {
                if (accepted.Contains(word_characters[i]))
                {
                    passcode.Add(i);
                }
            }

            string code = "";

            for (int i = 0; i < passcode.Count; i++)
            {
                code = code + passcode[i];
            }

            Console.WriteLine($"A valid password is {code}");
            Console.ReadKey();
        }
    }
}
