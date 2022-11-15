using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                                " 9. Ball pit               |  18. Day format         |  27. Electric car     \n");

            Console.WriteLine("Choose program: ");
            ConsoleKeyInfo userInput = Console.ReadKey();

            if (char.IsDigit(userInput.KeyChar))
            {
                int number = int.Parse(userInput.KeyChar.ToString());
                ChooseClass(number);
            }
        }

        static void ChooseClass(int id)
        {
            switch(id)
            {
                case 1:
                    DiceFace5.Dice();
                    break;

                case 2:
                    TempetureConverter.ConvertToFahrenheit();
                    TempetureConverter.ConvertToCentigrade();
                    break;
            }
        }
    }
}
