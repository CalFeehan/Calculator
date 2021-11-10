using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Calculator
{
    class Helper
    {
        public Helper()
        {

        }

        public static int InputCalculatorType()
        {
            while (true)
            {
                Console.WriteLine("Which calculator mode would you like? ");
                Console.WriteLine("1) Numbers");
                Console.WriteLine("2) Dates");
                Console.WriteLine("3) Exit");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1": return 1;
                    case "2": return 2;
                    case "3": return 3;
                    default:
                        Console.WriteLine("Please enter 1, 2 or 3.");
                        continue;
                }
            }
        }

        public static bool Repeat()
        {
            while (true)
            {
                Console.Write("Restart? (y/n)");
                string retry = Console.ReadLine();

                switch (retry)
                {
                    case "y": case "Y": return true;
                    case "n": case "N": return false;
                    default: continue;
                }
            }
        }
    }
}
