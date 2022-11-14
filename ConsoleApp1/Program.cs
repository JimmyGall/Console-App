using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
            // 1 - Structured Programs

        static void _1_Structured_Programs()
        {
            ConsoleApp1.DiceFace5.Dice(2);

            // 
            double C = 30;
            double F = ConsoleApp1.TempetureConverter.ConvertToFahrenheit(C);
            Console.WriteLine(C + " degrees C is " + F + " degrees F ");
            Console.WriteLine(F + " degrees F is " + C + " degrees C ");
            

        }
            
        // 2 - Selection
        
        // 3- Number data types
        
        // 4 - String data types
        
        // 5 - Counter-controlled iterations

        // 6 - Condition controlled iterations
         static void _6_Condition_controlled_iterations()
        {
            // Car value
            CarValue.Value(2, 12000, 4000);
        }

        // 7 - User inputs
        
        // 8 - Arrays and lists
        
        // 9 - Serial files
        
        // 10 - Mastery


        static void Main(string[] args)
        {
            _1_Structured_Programs();

            _6_Condition_controlled_iterations();
            
        }
    }
}
