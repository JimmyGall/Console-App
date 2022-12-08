using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CounterControlledIterations
{
    internal class Scramble
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Scramble");

            Console.WriteLine("Enter your word ");
            string word = Console.ReadLine();

            givePoints(word);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void givePoints(string word)
        {
            int points = 0;

            char[] word_characters = word.ToUpperInvariant().ToArray();

            Points point_enum;

            for (int i = 0; i < word_characters.Length; i++)
            {
                if (Enum.TryParse<Points>(word_characters[i].ToString(), out point_enum))
                {
                    points = points + ((int)point_enum);
                }
            }

            Console.WriteLine($"Your total amount of points is {points}");

            Console.ReadKey();
        }

        enum Points
        {
            E = 1,
            A = 1,
            I = 1,
            O = 1,
            N = 1,
            R = 1,
            T = 1,
            L = 1,
            S = 1,
            U = 1,

            D = 2,
            G = 2,

            B = 3,
            C = 3,
            M = 3,
            P = 3,

            F = 4,
            H = 4,
            V = 4,
            W = 4,
            Y = 4,

            K = 5,

            J = 8,
            X = 8,

            Q = 10,
            Z = 10
        }

    }
}
