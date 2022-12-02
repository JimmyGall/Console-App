using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConsoleCommands.FunStuff
{
    internal class PasswordHackCommand
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Command: Password Hack");

            Console.WriteLine("Enter your passcode: ");
            long code = ProgramMethods.ProgramMethods.returnLong(Console.ReadLine());

            crack_password(code);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void crack_password(long passcode)
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            for (int i = 0; i < passcode; i++)
            {
                if (i != passcode)
                {
                    Console.WriteLine($"Passcode: {i} is incorrect.");
                } else if (i == passcode)
                {
                    Console.WriteLine($"Found the correct passcode! {i}");
                    break;
                } else
                {
                    Console.WriteLine("Could not guess your passcode, must be strong.");
                    break;
                }
            }

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            Console.WriteLine($"Time took to crack the passcode: Hours: {ts.Hours} Minutes: {ts.Minutes} Milliseconds: {ts.Milliseconds}");

            Console.ReadKey();
        }
    }
}
