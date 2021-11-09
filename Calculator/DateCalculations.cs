using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class DateCalculations
    {
        public static DateTime InputDate()
        {
            DateTime userDate = new DateTime();
            while (true)
            {
                Console.Write("Please enter a date (dd/mm/yyyy): ");
                string stringDate = Console.ReadLine();

                try
                {
                    userDate = DateTime.Parse(stringDate);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter date as dd/mm/yyyy");
                    continue;
                }
                break;
            }

            return userDate;
        }

        public static int InputDaysToAdd()
        {
            int daysToAdd;
            while (true)
            {
                Console.Write("Days do you want to add? ");
                string userDaysToAdd = Console.ReadLine();

                try
                {
                    daysToAdd = int.Parse(userDaysToAdd);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Whole numbers only please.");
                    continue;
                }
                break;
            }

            return daysToAdd;
        }

        public static string PerformCalculation(DateTime userDate, int daysToAdd)
        {
            return userDate.AddDays(daysToAdd).ToShortDateString();
        }
    }
}