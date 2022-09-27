using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CDQuality
    {

        static void Sample(int Hz)
        {
            if (Hz == 44100)
            {
                Console.WriteLine("CD quality.");
            }

            if (Hz < 44100)
            {
                Console.WriteLine("Low quality.");
            }

            if (Hz > 44100)
            {
                Console.WriteLine("Compress");
            }
        }
    }
}
