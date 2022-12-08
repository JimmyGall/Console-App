using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringDataTypes
{
    internal class Valid_Email
    {

        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Valid email");

            Console.WriteLine("Enter the email address: ");
            string email = Console.ReadLine();

            valid_email(email);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void valid_email(string email)
        {
            if (!email.Contains("@") && !email.Contains("."))
            {
                Console.WriteLine($"This email '{email}' is not a valid email address!");
            } else
            {
                Console.WriteLine($"Email address '{email}' is valid!");
            }

            Console.ReadKey();
        }

    }
}
