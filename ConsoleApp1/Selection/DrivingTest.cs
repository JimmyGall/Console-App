using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DrivingTest
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Driving test");

            Console.WriteLine("Amount of faults in driving test: ");
            int fualts = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            Test(fualts);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void Test(int fualts)
        {
            if (fualts >= 15)
            {
                Console.WriteLine("Failed");
            } else
            {
                Console.WriteLine("Passed");
            }

            Console.ReadKey();
        }

    }
}
