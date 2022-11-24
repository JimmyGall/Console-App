using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringDataTypes
{
    public class Tweet
    {

        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Tweet");

            Console.WriteLine("Please enter your tweet: ");
            string tweet = Console.ReadLine();

            GoodTweet(tweet);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void GoodTweet(string input)
        {

            if (input.Length <= 20)
            {
                Console.WriteLine("False. Bad tweet.");
            } else
            {
                Console.WriteLine("True. Good tweet.");
            }

            Console.ReadKey();
        }
    }
}
