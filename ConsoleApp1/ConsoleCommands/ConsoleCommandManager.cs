using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConsoleCommands
{
    internal class ConsoleCommandManager
    {
        public static void DisplayPrograms(bool unknown)
        {
            Console.Clear();
            ProgramMethods.ProgramMethods.ProgramTitle("Main menu");


            Console.WriteLine("Please choose one of the following programs to run: \n" +
                    "---\n" +
                    "1. Structured Programs:    | 2. Selection:           | 3. Number data types: \n" +
                    " 1. Dice Face 5            |  10. Driving Test       |  19. Save the change  \n" +
                    " 2. Temperature converter  |  11. Max                |  20. Polyhendral dice \n" +
                    " 3. Characters             |  12. States of water    |  21. Clamp            \n" +
                    " 4. Fish tank volume       |  13. Career quote       |  22. Leap year        \n" +
                    " 5. Microscopy             |  14. Currency converter |  23. Hours in a day   \n" +
                    " 6. Carpet cost            |  15. Nitrate            |  24. Dice game        \n" +
                    " 7. Energy bill calculator |  16. Exam grade         |  25. Divisable        \n" +
                    " 8. Circle properties      |  17. Periodic table     |  26. Dogs life        \n" +
                    " 9. Ball pit               |  18. Day format         |  27. Electric car     \n" +
                    "\n" +
                    "For more commands, type 'help'.");

            if (unknown) { Console.WriteLine("Unknown command, try again."); }

            string userInput = Console.ReadLine();

            Command(userInput);
        }

        public static void Command(string id)
        {
            switch (id)
            {
                case "1":
                    DiceFace5.Run();
                    break;

                case "2":
                    TempetureConverter.Run();
                    break;

                case "3":
                    Characters.Run();
                    break;

                case "4":
                    FishTankVolume.Run();
                    break;

                case "5":
                    Microscopy.Run();
                    break;

                case "6":
                    CarpetCost.Run();
                    break;

                case "7":
                    EnergyBillCalculator.Run();
                    break;

                case "8":
                    CircleProperties.Run();
                    break;

                case "9":
                    Ballpit.Run();
                    break;

                case "10":
                    DrivingTest.Run();
                    break;

                case "11":
                    Max.Run();
                    break;

                case "12":
                    StatesOfWater.Run();
                    break;

                case "13":
                    CareerQuote.Run();
                    break;

                case "14":
                    CurrencyConvertor.Run();
                    break;

                case "15":
                    Nitrate.Run();
                    break;

                case "16":
                    ExamGrade.Run();
                    break;

                case "17":
                    PeriodicTable.Run();
                    break;

                case "18":
                    DayFormat.Run();
                    break;

                case "19":
                    SaveTheChange.Run();
                    break;

                case "20":
                    PolyhedralDice.Run();
                    break;

                case "21":
                    Clamp.Run();
                    break;

                case "22":
                    LeapYear.Run();
                    break;

                case "23":
                    HoursInADay.Run();
                    break;

                case "24":
                    DiceGame.Run();
                    break;

                case "25":
                    Divisible.Run();
                    break;

                case "26":
                    DogsLife.Run();
                    break;

                case "27":
                    ElectricCar.Run();
                    break;


                //Extra commands

                case "help":
                    ConsoleCommands.HelpCommand.Execute();
                    break;

                case "exit":

                case "e":

                case "terminate":

                case "off":
                    ConsoleCommands.ExitCommand.Execute();
                    break;

                case "FPrint":
                    ConsoleCommands.FPrintCommand.Execute();
                    break;

                default:
                    DisplayPrograms(true);
                    break;
            }
        }

    }
}
