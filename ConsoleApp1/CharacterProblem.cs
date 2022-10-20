using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CharacterProblem
    {
        public static void convert()
        {
            string message = "0123456789";
            Console.WriteLine("Message: " + message);

            string newMessage = message
                .Replace('0', 'a')
                .Replace('1', 'b')
                .Replace('2', 'c')
                .Replace('3', 'd')
                .Replace('4', 'A')
                .Replace('5', 'B')
                .Replace('6', 'C')
                .Replace('7', 'D')
                .Replace('8', '@')
                .Replace('9', '#');




            Console.WriteLine("New message: " + newMessage);
            Console.ReadKey();
        }
    }
}
