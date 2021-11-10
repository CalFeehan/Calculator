using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Calculator
{
    class Helper
    {

        public static string InputCalculatorType()
        {
            while (true)
            {
                Console.WriteLine("Which calculator mode would you like? \n 1) Numbers \n 2) Dates \n 3) Exit");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1": return "Number";
                    case "2": return "Dates";
                    case "3": return "Exit";
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
