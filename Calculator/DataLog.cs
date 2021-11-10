using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Calculator
{
    class DataLog
    {
        private const string path = @"C:\Users\Callum.Feehan\Downloads\Log.txt";

        public DataLog()
        {
            using (FileStream fs = File.Create(path))
            {
                byte[] opener = new UTF8Encoding(true).GetBytes($"Calculations Log: {DateTime.Now}. \n");
                fs.Write(opener, 0, opener.Length);
                Console.WriteLine("File created");
            }
        }

        public void AppendDataLog(string questionToAddToLog, string resultToAddToLog)
        {
            string addToLog = questionToAddToLog + " = " + resultToAddToLog + "\n";
            File.AppendAllText(path, addToLog);
        }

    }
}
