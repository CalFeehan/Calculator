using System;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {   
            // First pass ensure value assigned to variable. Ensures operator passed in.
            string userOperator;
            do 
            {
                Console.Write("Please enter operator (+ - / *): ");
                userOperator = Console.ReadLine();

            } while (userOperator != "+" && userOperator != "-" && userOperator != "*" && userOperator != "/");

            // Do not extend below loop. Be careful when modifying not to create infinite loop.
            int number1;
            while (true)
            {
                Console.Write("Please enter first number: ");
                string userNumber1 = Console.ReadLine();
                try
                {
                    number1 = Int32.Parse(userNumber1);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Whole numbers only please.");
                    continue;
                }
                break;
            }

            // Do not extend below loop. Be careful when modifying not to create infinite loop.
            int number2;
            while (true)
            {
                Console.Write("Please enter second number: ");
                string userNumber2 = Console.ReadLine();
                
                try
                {
                    number2 = Int32.Parse(userNumber2);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Whole numbers only please.");
                    continue;
                }
                break;
            }

            // Performs calculations
            switch (userOperator){
                case "+":
                    Console.Write(number1 + number2);
                    break;
                case "-":
                    Console.Write(number1 - number2);
                    break;
                case "*":
                    Console.Write(number1 * number2);
                    break;
                case "/":
                    Console.Write(number1 / number2);
                    break;
                default:
                    break;
            }
        }
    }
}
