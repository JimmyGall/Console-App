using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DiceFace
    {

        public static void Dice(int number)
        {
            switch (number)
            {
                case 1:

                    Console.WriteLine("00000000000");
                    Console.WriteLine("0         0");
                    Console.WriteLine("0         0");
                    Console.WriteLine("0    #    0");
                    Console.WriteLine("0         0");
                    Console.WriteLine("0         0");
                    Console.WriteLine("00000000000");
                    break;

                case 2:

                    Console.WriteLine("00000000000");
                    Console.WriteLine("0         0");
                    Console.WriteLine("0      #  0");
                    Console.WriteLine("0         0");
                    Console.WriteLine("0  #      0");
                    Console.WriteLine("0         0");
                    Console.WriteLine("00000000000");
                    break;

                case 3:

                    Console.WriteLine("00000000000");
                    Console.WriteLine("0         0");
                    Console.WriteLine("0      #  0");
                    Console.WriteLine("0    #    0");
                    Console.WriteLine("0  #      0");
                    Console.WriteLine("0         0");
                    Console.WriteLine("00000000000");
                    break;

                case 4:

                    Console.WriteLine("00000000000");
                    Console.WriteLine("0         0");
                    Console.WriteLine("0  #   #  0");
                    Console.WriteLine("0         0");
                    Console.WriteLine("0  #   #  0");
                    Console.WriteLine("0         0");
                    Console.WriteLine("00000000000");
                    break;

                case 5:

                    Console.WriteLine("00000000000");
                    Console.WriteLine("0         0");
                    Console.WriteLine("0  #   #  0");
                    Console.WriteLine("0    #    0");
                    Console.WriteLine("0  #   #  0");
                    Console.WriteLine("0         0");
                    Console.WriteLine("00000000000");

                    break;

                case 6:

                    Console.WriteLine("00000000000");
                    Console.WriteLine("0         0");
                    Console.WriteLine("0  #   #  0");
                    Console.WriteLine("0  #   #  0");
                    Console.WriteLine("0  #   #  0");
                    Console.WriteLine("0         0");
                    Console.WriteLine("00000000000");

                    break;

                default:
                    Console.WriteLine("Invalid number");
                    break;
            }

            Console.ReadKey();
        }

    }
}
