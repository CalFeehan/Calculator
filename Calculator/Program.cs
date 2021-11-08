using System;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
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

            Console.Write(number1 * number2);

        }
    }
}
