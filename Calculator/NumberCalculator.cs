using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class NumberCalculator
    {
        private DataLog dataLog;

        public NumberCalculator(DataLog dataLog)
        {
            this.dataLog = dataLog;
        }

        public void RunNumberCalculator()
        {
            string userOperator = InputOperator();
            int iterations = InputIterations();
            int[] intArray = (int[])InputNumbers(iterations).Clone();
            double result = PerformCalculation(userOperator, iterations, intArray);
            dataLog.AppendDataLog(String.Join(userOperator, intArray), result.ToString());
            Console.WriteLine(result);
        }

        private string InputOperator()
        {
            string userOperator;
            do
            {
                Console.Write("Please enter the operator (+ - / *): ");
                userOperator = Console.ReadLine();

            } while (userOperator != "+" && userOperator != "-" && userOperator != "*" && userOperator != "/");

            return userOperator;
        }   

        private int InputIterations()
        {
            int iterations;
            while (true)
            {
                Console.Write("How many numbers do you want? ");
                string userIterations = Console.ReadLine();

                try
                {
                    iterations = int.Parse(userIterations);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Whole numbers only please.");
                    continue;
                }
                break;
            }

            return iterations;
        }

        private Array InputNumbers(int iterations)
        {
            string[] stringArray = new string[iterations];
            int[] intArray = new int[iterations];
            for (int i = 0; i < iterations; i++)
            {
                while (true)
                {
                    Console.Write($"Please enter number {i + 1}: ");
                    stringArray[i] = Console.ReadLine();
                    try
                    {
                        intArray[i] = int.Parse(stringArray[i]);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Whole numbers only please.");
                        continue;
                    }
                    break;
                }
            }

            return intArray;
        }

        private double PerformCalculation(string userOperator, int iterations, int[] intArray)
        {
            double result = Convert.ToDouble(intArray[0]);
            switch (userOperator)
            {
                case "+":
                    for (int i = 1; i < iterations; i++)
                        result += Convert.ToDouble(intArray[i]);
                    return result;
                case "-":
                    for (int i = 1; i < iterations; i++)
                        result -= Convert.ToDouble(intArray[i]);
                    return result;
                case "*":
                    for (int i = 1; i < iterations; i++)
                        result *= Convert.ToDouble(intArray[i]);
                    return result;
                case "/":
                    for (int i = 1; i < iterations; i++)
                        result /= Convert.ToDouble(intArray[i]);
                    return result;
                default:
                    break;
            }
            return result;
        }
    }
}
