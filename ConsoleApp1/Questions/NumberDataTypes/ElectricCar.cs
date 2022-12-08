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

            Console.WriteLine("Enter the amount of minutes for charging service: ");

            int minutes = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            Car(minutes);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        //Charged £1 per session and 20p per minute
        //Customer is still charged for 15 minute use of the car.

        //Min number of points recived is 22
        //Gain 1.5 points per minute, this is rounded down.

        static void Car(int minutes)
        {
            double cost = 1;
            double points = 22;

            if (minutes <= 15)
            {
                Console.WriteLine($"Cost for service: {cost}");
                Console.WriteLine($"Points recieved for using service: {points}");
            } else
            {
                minutes -= 15;

                for (int i = 0; i < minutes; i++)
                {
                    cost += 0.20;
                    points += 1.5;
                }

                points = Convert.ToSingle(points);

                Console.WriteLine($"Cost for service: {cost}");
                Console.WriteLine($"Points recieved for using service (Rounded down): {points} ");
            }

            Console.ReadKey();
        }
    }
}
