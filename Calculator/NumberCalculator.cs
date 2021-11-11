using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class NumberCalculator
    {
        private DataLog dataLog;

        // constructor
        public NumberCalculator(DataLog dataLog) { this.dataLog = dataLog; }

        public void RunNumberCalculator()
        {
            string userOperator = InputOperator();
            int iterations = InputIterations();
            List<int> intList = InputNumbers(iterations);
            double result = PerformCalculation(userOperator, iterations, intList);
            dataLog.AppendDataLog(String.Join(userOperator, intList), result.ToString());
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

                try { iterations = int.Parse(userIterations); }
                catch (FormatException)
                {
                    Console.WriteLine("Whole numbers only please.");
                    continue;
                }
                break;
            }

            return iterations;
        }

        private List<int> InputNumbers(int iterations)
        { 
            List<int> intList = new List<int>();

            for (int i = 0; i < iterations; i++)
            {
                while (true)
                {
                    Console.Write($"Please enter number {i + 1}: ");
                    string userInput = Console.ReadLine();

                    try { intList.Add(int.Parse(userInput)); }
                    catch (FormatException)
                    {
                        Console.WriteLine("Whole numbers only please.");
                        continue;
                    }
                    break;
                }
            }

            return intList;
        }

        private double PerformCalculation(string userOperator, int iterations, List<int> intList)
        {
            double result = Convert.ToDouble(intList[0]);
            switch (userOperator)
            {
                case "+":
                    for (int i = 1; i < iterations; i++)
                        result += Convert.ToDouble(intList[i]);
                    return result;
                case "-":
                    for (int i = 1; i < iterations; i++)
                        result -= Convert.ToDouble(intList[i]);
                    return result;
                case "*":
                    for (int i = 1; i < iterations; i++)
                        result *= Convert.ToDouble(intList[i]);
                    return result;
                case "/":
                    for (int i = 1; i < iterations; i++)
                        result /= Convert.ToDouble(intList[i]);
                    return result;
                default:
                    break;
            }
            return result;
        }
    }
}
