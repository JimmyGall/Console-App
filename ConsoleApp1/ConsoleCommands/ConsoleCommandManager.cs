using ConsoleApp1.ConditionControlledIterations;
using ConsoleApp1.CounterControlledIterations;
using ConsoleApp1.StringDataTypes;
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

            Console.SetWindowSize(200, 40);

            ProgramMethods.ProgramMethods.ProgramTitle("Main menu");


            Console.WriteLine("Please choose one of the following programs to run: \n" +
                    "------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- \n" +
                    "1. Structured programs:    | 2. Selection:           | 3. Number data types: | 4. String data types    | 5. Counter-controlled iterations | 6. Condition-Controlled iterations  \n" +
                    " 1. Dice Face 5            |  10. Driving Test       |  19. Save the change  |  28. Tweet              |  37. Times table                 |  46. Compound Interest              \n" +
                    " 2. Temperature converter  |  11. Max                |  20. Polyhendral dice |  29. Initial & Surname  |  38. Factorial                   |  47. Car Value                      \n" +
                    " 3. Characters             |  12. States of water    |  21. Clamp            |  30. Inventory          |  39. Ten green bottles           |  48. Discount Counter               \n" +
                    " 4. Fish tank volume       |  13. Career quote       |  22. Leap year        |  31. Airline ticket     |  40. ASCII Art                   |  49. Lottery                        \n" +
                    " 5. Microscopy             |  14. Currency converter |  23. Hours in a day   |  32. Teacher code       |  41. Fizz Buzz                   |\n" +
                    " 6. Carpet cost            |  15. Nitrate            |  24. Dice game        |  33. Valid Email        |  42. Scramble                    |\n" +
                    " 7. Energy bill calculator |  16. Exam grade         |  25. Divisable        |  34. Name seperator     |  43. Passcode                    |\n" +
                    " 8. Circle properties      |  17. Periodic table     |  26. Dogs life        |  35. Naming conventions |  44. Cassini                     |\n" +
                    " 9. Ball pit               |  18. Day format         |  27. Electric car     |  36. ASCII to EBCDIC    |  45. Prime Number                |\n" +
                    "------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- \n" +
                    "For more commands, type 'help'.");

            if (unknown) { Console.WriteLine("Unknown command, try again."); }

            string userInput = Console.ReadLine();

            Command(userInput);
        }

        public static void Command(string id)
        {
            switch (id)
            {
                #region Region: Structured programs

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
                #endregion

                #region Region: Selection
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
                #endregion

                #region Region: Number data types
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
                #endregion

                #region Region: String data types
                case "28":
                    Tweet.Run();
                    break;

                case "29":
                    Initial_Surname.Run();
                    break;

                case "30":
                    Inventory.Run();
                    break;

                case "31":
                    AirlineTicket.Run();
                    break;

                case "32":
                    TeacherCode.Run();
                    break;

                case "33":
                    Valid_Email.Run();
                    break;

                case "34":
                    NameSeperator.Run();
                    break;

                case "35":
                    NamingConventions.Run();
                    break;

                case "36":
                    ASCII_To_EBCDIC.Run();
                    break;
                #endregion

                #region Region: Counter-Controlled Iterations

                case "37":
                    TimesTable.Run();
                    break;

                case "38":
                    Factorial.Run();
                    break;

                case "39":
                    TenGreenBottles.Run();
                    break;

                case "40":
                    ASCII_Art.Run();
                    break;

                case "41":
                    FizzBuzz.Run();
                    break;

                case "42":
                    Scramble.Run();
                    break;

                case "43":
                    Passcode.Run();
                    break;

                case "44":
                    Cassini.Run();
                    break;

                case "45":
                    PrimeNumber.Run();
                    break;

                #endregion

                //Condition-Controlled Iterations

                case "46":
                    CompoundInterest.Run();
                    break;

                case "47":
                    CarValue.Run();
                    break;

                case "48":
                    DiscountCounter.Run();
                    break;

                case "49":
                    Lottery.Run();
                    break;

                #region Region: EXTRA COMMANDS

                case "help":
                    ConsoleCommands.HelpCommand.Execute();
                    break;

                case "crack password":
                    ConsoleCommands.FunStuff.PasswordHackCommand.Run();
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

                #endregion

                default:
                    DisplayPrograms(true);
                    break;
            }
        }

    }
}
