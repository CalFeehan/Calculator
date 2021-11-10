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
                int choice = Helper.InputCalculatorType();

                switch (choice)
                {
                    case 1: numberCalculator.RunNumberCalculator(); break;
                    case 2: dateCalculator.RunDateCalculator(); break;
                    default: repeat = false; continue;
                }
                
                repeat = Helper.Repeat();
            }
        }
    }
}
