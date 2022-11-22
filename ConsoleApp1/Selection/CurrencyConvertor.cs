using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CurrencyConvertor
    {

        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Currency Convertor");

            Console.WriteLine("Please choose a currecy to convert: \n" +
                              " 1. GDP to USD (USD)\n" +
                              " 2. GDP to Euro (EURO)\n" +
                              " 3. GDP to Yuan (YUAN)\n" +
                              " 4. GDP to Yen (YEN)\n");

            string chosen_currency = Console.ReadLine();

            double amount;

            switch (chosen_currency)
            {

                case "USD":
                    Console.WriteLine("Please enter the amount of GDP you would like to exchange: ");
                    amount = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

                    ExchangeGDPToUSD(amount);
                    break;

                case "EURO":
                    Console.WriteLine("Please enter the amount of GDP you would like to exchange: ");
                    amount = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

                    ExchangeGDPToEuro(amount);
                    break;

                case "YUAN":
                    Console.WriteLine("Please enter the amount of GDP you would like to exchange: ");
                    amount = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

                    ExchangeGDPToYuan(amount);
                    break;

                case "YEN":
                    Console.WriteLine("Please enter the amount of GDP you would like to exchange: ");
                    amount = ProgramMethods.ProgramMethods.returnDouble(Console.ReadLine());

                    CurrencyConvertor.ExchangeGDPToYen(amount);
                    break;
            }

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        public static void ExchangeGDPToUSD(double amount)
        {
            double exchanged = amount * 1.14;
            Console.WriteLine("GBP to USD :: " + exchanged);
            Console.ReadKey();
        }

        public static void ExchangeGDPToEuro(double amount)
        {
            double exchanged = amount * 1.15;
            Console.WriteLine("GBP to Euro :: " + exchanged);
            Console.ReadKey();
        }

        public static void ExchangeGDPToYuan(double amount)
        {
            double exchanged = amount * 8.09;
            Console.WriteLine("GBP to Yuan :: " + exchanged);
            Console.ReadKey();
        }

        public static void ExchangeGDPToYen(double amount)
        {
            double exchanged = amount * 164.38;
            Console.WriteLine("GBP to Yen :: " + exchanged);
            Console.ReadKey();
        }
    }
}
