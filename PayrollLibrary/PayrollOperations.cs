using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace PayrollLibrary
{
    public class PayrollOperations
    {
       static string NewRecord = "";
       static string[] Record;



        public static bool compareDate(string Date)
        {
            return (Convert.ToDateTime(Date).Year < 2018);
        }
        public static double calculateNewSalary(string slary)
        {
            return (Convert.ToDouble(slary) * 1.1);
        }

        public static string readLines(string line)
        {
            line = line.Replace("\\n", "");
            line = line.Replace("\\r", "");
            return line;
        }
        public static bool testFilePath(string path)
        {
            return File.Exists(path);
        }

        public static string[] readTextFile(string path)
        {
            return File.ReadAllLines(path);
        }

        public static string writeToFile(string filePath)
        {
            if(testFilePath(filePath))
            {
                foreach(var line in readTextFile(filePath))
                {
                    if (line != "")
                    {
                        string[] Record = readLines(line).Split('\t');
                        if (PayrollOperations.compareDate(Record[2]))
                        {
                            NewRecord += readLines(line) + "\t" + calculateNewSalary(Record[3]) + Environment.NewLine;
                        }
                        else
                        {
                            NewRecord += readLines(line) + "\t" + Record[3] + Environment.NewLine;
                        }
                    }
                }               
            }
            return NewRecord;
        }
    }
}
