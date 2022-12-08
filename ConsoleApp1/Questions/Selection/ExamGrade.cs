using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ExamGrade
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Exam grade");

            Console.WriteLine("What score did you get on your exam? ");
            int score = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            Grade(score);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        public static void Grade(int score)
        {
            if (score < 2)
            {
                Console.WriteLine("Grade U");
            } else if (score == 2)
            {
                Console.WriteLine("Grade 1");
            }
            else if (score < 4)
            {
                Console.WriteLine("Grade 2");
            }
            else if (score < 13)
            {
                Console.WriteLine("Grade 3");
            }
            else if (score < 22)
            {
                Console.WriteLine("Grade 4");
            }
            else if (score < 31)
            {
                Console.WriteLine("Grade 5");
            }
            else if (score < 41)
            {
                Console.WriteLine("Grade 6");
            }
            else if (score < 54)
            {
                Console.WriteLine("Grade 7");
            }
            else if (score < 67)
            {
                Console.WriteLine("Grade 8");
            }
            else if (score < 80)
            {
                Console.WriteLine("Grade 9");
            } else
            {
                Console.WriteLine("Error");
            }

            Console.ReadKey();
        }

    }
}
