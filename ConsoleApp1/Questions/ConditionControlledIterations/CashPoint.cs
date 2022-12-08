﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Questions.ConditionControlledIterations
{
    internal class CashPoint
    {
        public static void Run()
        {
            ProgramMethods.ProgramMethods.ProgramTitle("Program: Cash Point");

            Console.WriteLine("How much money do you want? ");
            int money = ProgramMethods.ProgramMethods.returnInt(Console.ReadLine());

            returnMoney(money);

            ConsoleCommands.ConsoleCommandManager.DisplayPrograms(false);
        }

        static void returnMoney(int money)
        {
            int currentAmount = money;

            List<Int32> notes = new List<int>();

            do
            {

                if (currentAmount % 20 == 0)
                {
                    currentAmount /= 20;
                    notes.Add(20);
                }

                if (currentAmount % 10 == 0)
                {
                    currentAmount /= 10;
                    notes.Add(10);
                }

                if (currentAmount % 5 == 0)
                {
                    currentAmount /= 5;
                    notes.Add(5);
                }

                if (currentAmount % 1 == 0)
                {
                    currentAmount /= 1;
                    notes.Add(1);
                }

            } while (currentAmount != 0);

            string message = "";

            notes.Sort();

            for (int i = 0; i < notes.Count; i++)
            {
                message += $"{notes[i]} ";
            }

            Console.WriteLine("You got: " + message);
        }
    }
}
