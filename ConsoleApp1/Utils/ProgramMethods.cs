using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ProgramMethods
{
    internal class ProgramMethods
    {
        public static void ProgramTitle(string title)
        {
            Console.Title = "Console Application (v0.2) - " + title;
        }


        public static double returnDouble(string message)
        {
            try
            {
                return Double.Parse(message);
            }
            catch (Exception e)
            {
                Console.WriteLine("No value entered defualting to 0");
                return 0;
            }
        }

        public static int returnInt(string message)
        {
            try
            {
                return Int32.Parse(message);
            }
            catch (Exception e)
            {
                Console.WriteLine("No value entered defualting to 0");
                return 0;
            }
        }

        public static long returnLong(string message)
        {
            try
            {
                return Int64.Parse(message);
            }
            catch (Exception e)
            {
                Console.WriteLine("No value entered defualting to 0");
                return 0;
            }
        }
    }
}
