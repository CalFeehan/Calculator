using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class DateCalculator
    {
        private DataLog dataLog;

        // constructor
        public DateCalculator(DataLog dataLog) { this.dataLog = dataLog; }

        public void RunDateCalculator()
        {
            DateTime userDate = InputDate();
            int daysToAdd = InputDaysToAdd();
            string result = PerformCalculation(userDate, daysToAdd);
            dataLog.AppendDataLog($"{userDate} + {daysToAdd} days = ", result);
            Console.WriteLine(result);
        }

        private DateTime InputDate()
        {
            DateTime userDate = new DateTime();
            while (true)
            {
                Console.Write("Please enter a date (dd/mm/yyyy): ");
                string stringDate = Console.ReadLine();

                try { userDate = DateTime.Parse(stringDate); }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter date as dd/mm/yyyy");
                    continue;
                }
                break;
            }
            return userDate;
        }

        private int InputDaysToAdd()
        {
            int daysToAdd;
            while (true)
            {
                Console.Write("Days do you want to add? ");
                string userDaysToAdd = Console.ReadLine();

                try { daysToAdd = int.Parse(userDaysToAdd); }
                catch (FormatException)
                {
                    Console.WriteLine("Whole numbers only please.");
                    continue;
                }
                break;
            }
            return daysToAdd;
        }

        private string PerformCalculation(DateTime userDate, int daysToAdd)
        {
            return userDate.AddDays(daysToAdd).ToShortDateString();
        }
    }
}