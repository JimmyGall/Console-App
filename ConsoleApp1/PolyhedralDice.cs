using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PolyhedralDice
    {
        public static void DiceProblem(int faces)
        {
            Random random = new Random();
            int value = random.Next(0, faces);

            Console.WriteLine("Dice returned " + value + "\nFaces: " + faces);
            Console.ReadKey();
        }
    }
}
