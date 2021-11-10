using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DataLog dataLog = new DataLog();
            NumberCalculator numberCalculator = new NumberCalculator(dataLog);
            DateCalculator dateCalculator = new DateCalculator(dataLog);

            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("==========================");

            bool repeat = true;
            while (repeat)
            {
                string choice = Helper.InputCalculatorType();

                switch (choice)
                {
                    case "Number": numberCalculator.RunNumberCalculator(); break;
                    case "Dates": dateCalculator.RunDateCalculator(); break;
                    default: repeat = false; continue;
                }
                
                repeat = Helper.Repeat();
            }
        }
    }
}
