using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PolyhedralDice
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Polyhedral Dice");

            Console.WriteLine("Please enter the max faces on the dice: ");

            int faces = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            DiceProblem(faces);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        public static void DiceProblem(int faces)
        {
            Random random = new Random();
            int value = random.Next(0, faces);

            Console.WriteLine("Dice returned " + value + "\nFaces: " + faces);
            Console.ReadKey();
        }
    }
}
