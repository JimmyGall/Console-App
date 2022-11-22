using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StatesOfWater
    {

        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: States of Water");

            Console.WriteLine("Water status: ");
            int status = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            Status(status);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void Status(int status)
        {
            if (status >= 100)
            {
                Console.WriteLine("Gaseous");
            } else if (status >= 1 && status <= 99)
            {
                Console.WriteLine("Liquid");
            } else if (status <= 0)
            {
                Console.WriteLine("Solid");
            }

            Console.ReadKey();
        }

    }
}
