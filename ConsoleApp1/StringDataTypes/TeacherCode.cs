using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringDataTypes
{
    internal class TeacherCode
    {

        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Teacher code");

            Console.WriteLine("Enter the student's First name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the student's Middle name: ");
            string middleName = Console.ReadLine();

            Console.WriteLine("Enter the student's Sur name: ");
            string surName = Console.ReadLine();


            code(firstName, middleName, surName);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void code(string firstName, string middleName, string surName)
        {
            string FIRST_NAME = firstName.Substring(0, 1);

            string MIDDLE_NAME = "";

            if (String.IsNullOrEmpty(middleName))
            {
                MIDDLE_NAME = "Z";
            } else
            {

                MIDDLE_NAME = firstName.Substring(0, 1);
            }

            string SUR_NAME = surName.Substring(0, 1);

            Console.WriteLine($"{FIRST_NAME}{MIDDLE_NAME}{SUR_NAME}");

            Console.ReadKey();
        }
    }
}
