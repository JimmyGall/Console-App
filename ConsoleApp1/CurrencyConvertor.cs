using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CurrencyConvertor
    {

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
