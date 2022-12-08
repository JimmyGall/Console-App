using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CareerQuote
    {

        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Career Quote");

            Console.WriteLine("What is your job? ");
            string first = Console.ReadLine();

            Job(first.ToLower());

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void Job(string Job)
        {
            if (Job == "engineer")
            {
                Console.WriteLine("The engineer has been, and is, a maker of history.");

            } else if (Job == "developer")
            {
                Console.WriteLine("Logical thinking, passion and perseverance is the paint of your palette.");

            } else if (Job == "analyst")
            {
                Console.WriteLine("Seeing what other people can't see gives you great vision");

            } else
            {
                Console.WriteLine("I'm sorry, We could not find a quote for your job.");
            }

            Console.ReadKey();
        }

    }
}
