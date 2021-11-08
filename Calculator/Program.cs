using System;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("==========================");

            bool repeat = true;
            while (repeat)
            {
                string userOperator = Calculations.InputOperator();
                int iterations = Calculations.InputIterations();
                int[] intArray = (int[])Calculations.InputNumbers(iterations).Clone();
                Console.WriteLine(Calculations.PerformCalculation(userOperator, iterations, intArray));
                repeat = Calculations.Repeat();
            }

        }
    }
}
