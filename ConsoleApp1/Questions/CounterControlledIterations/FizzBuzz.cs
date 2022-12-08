using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CounterControlledIterations
{
    internal class FizzBuzz
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Fizz Buzz");

            Console.WriteLine("Enter a number: ");
            int x = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            Foo(x);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void Foo(int x)
        {
            string message = "";

            for (int i = 0; i < x; i++)
            {

                if (i % 3 == 0)
                {
                    message = message + $"{i} = Fizz\n";
                }
                else if (i % 5 == 0)
                {
                    message = message + $"{i} = Buzz\n";
                } else
                {
                    message = message + $"{i} = Foo\n";
                }
            }

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
