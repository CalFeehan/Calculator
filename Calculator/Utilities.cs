using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Calculator
{
    class Utilities
    {
        private const string path = @"C:\Users\Callum.Feehan\Downloads\Log.txt";

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

        public static void ResetDataLog()
        {
            using (FileStream fs = File.Create(path))
            {
                byte[] opener = new UTF8Encoding(true).GetBytes($"Calculations Log: {DateTime.Now}. \n");
                fs.Write(opener, 0, opener.Length);
                Console.WriteLine("File created");
            }
        }

        public static void AppendDataLog(string questionToAddToLog, string resultToAddToLog)
        {
            string addToLog = questionToAddToLog + " = " + resultToAddToLog + "\n";
            File.AppendAllText(path, addToLog);
        }
    }
}
