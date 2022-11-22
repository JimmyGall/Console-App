using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ElectricCar
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Electric Car");

            Console.WriteLine("Enter the year: ");

            int year = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());


            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        public static void Car()
        {

        }
    }
}
