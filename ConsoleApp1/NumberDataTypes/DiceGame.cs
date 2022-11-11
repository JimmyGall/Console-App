using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DiceGame
    {
        static Random random = new Random();

        static int potentialScore;

        public static void function()
        {
            int score = 0;
            
            Console.WriteLine("Dice roll 1: " + ScoreDice());
            Console.WriteLine("Dice roll 2: " + ScoreDice());
            Console.WriteLine("Dice roll 3: " + ScoreDice());

            Console.WriteLine("\nAre all of your numbers equal? Y N");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                score += potentialScore;
                potentialScore = 0;

                Console.WriteLine("Score: " + score);
                score = 0;
                Console.ReadKey();

            } else if (Console.ReadKey().Key == ConsoleKey.N)
            {
                Console.WriteLine("Are 2 of the dice equal?");

                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    


                } else if (Console.ReadKey().Key == ConsoleKey.N)
                {
                    score = 0;
                    Console.WriteLine("Score: " + score);
                    Console.ReadKey();
                }
            }
        }

        public static int ScoreDice()
        {
            int value = random.Next(1, 6);
            potentialScore += value;
            return value;
        }

    }
}
