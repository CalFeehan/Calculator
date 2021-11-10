using System;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            Utilities.ResetDataLog();
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("==========================");

            bool repeat = true;
            while (repeat)
            {

                int choice = Utilities.InputCalculatorType();

                if (choice == 1)
                {
                    string userOperator = NumberCalculations.InputOperator();
                    int iterations = NumberCalculations.InputIterations();
                    int[] intArray = (int[])NumberCalculations.InputNumbers(iterations).Clone();
                    double result = NumberCalculations.PerformCalculation(userOperator, iterations, intArray);
                    Console.WriteLine(result);

                    Utilities.AppendDataLog(String.Join(userOperator, intArray), result.ToString());
                } 
                else if (choice == 2)
                {
                    DateTime userDate = DateCalculations.InputDate();
                    int daysToAdd = DateCalculations.InputDaysToAdd();
                    string result = DateCalculations.PerformCalculation(userDate, daysToAdd);
                    Console.WriteLine(result);

                    Utilities.AppendDataLog($"{userDate} + {daysToAdd} days = ", result);
                } else
                {
                    repeat = false;
                    continue;
                }
                
                repeat = Utilities.Repeat();
            }
        }
    }
}
