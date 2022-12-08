using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CounterControlledIterations
{
    internal class Cassini
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Cassini");

            Console.WriteLine("Enter your binary number ");
            string binary = Console.ReadLine();

            OddParity(binary);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void OddParity(string binary)
        {
            char[] binary_characters = binary.ToArray();

            int numberOfOnes = 0;

            for (int i = 0; i < binary_characters.Length; i++)
            {
                if (binary_characters[i] == '1')
                {
                    numberOfOnes += 1;
                }
            }

            if (numberOfOnes % 2 == 0)
            {
                Console.WriteLine("False, number of ones in binary is even.");
            }
            else
            {
                Console.WriteLine("True, number of ones in binary is odd.");
            }

            Console.ReadKey();
        }
    }
}
