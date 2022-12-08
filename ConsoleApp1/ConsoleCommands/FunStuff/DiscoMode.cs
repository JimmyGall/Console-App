using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.ConsoleCommands.FunStuff
{
    internal class DiscoMode
    {
        static Thread thread = new Thread(new ThreadStart(DiscoModeThread));

        public static void Execute()
        {

            if (thread.IsAlive)
            {
                thread.Abort();
                Console.ForegroundColor = ConsoleColor.Gray;
            } else
            {
                thread = new Thread(new ThreadStart(DiscoModeThread));
                thread.Start();
            }

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static long executedAmount;

         static void DiscoModeThread()
         {
            try
            {
                for (int i = 0; i < 16; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;

                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;

                        case 2:
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            break;

                        case 3:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;

                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            break;

                        case 5:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;

                        case 6:
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;

                        case 7:
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            break;

                        case 8:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;

                        case 9:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;

                        case 10:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;

                        case 11:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;

                        case 12:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;

                        case 13:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;

                        case 14:
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                        default:
                            i = 0;
                            break;
                    }

                    executedAmount++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
