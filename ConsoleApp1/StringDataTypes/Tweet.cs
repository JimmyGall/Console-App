using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringDataTypes
{
    internal class Tweet
    {

        static void GoodTweet()
        {
            Console.WriteLine("Please enter your tweet: ");

            string input = Console.ReadLine();

            if (input.Length <= 20)
            {
                Console.WriteLine("False. Bad tweet.");
            } else
            {
                Console.WriteLine("True. Good tweet.");
            }
        }

    }
}
