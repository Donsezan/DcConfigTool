using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static int _month = 1;
        private const string Pattern = @"Date\(\d{13}\)";

        public static void Main(string[] rgs)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            

            var line = ReadFileToString("MonthChallenges0117.js");
            WorkWithConsole();

            int daysInMonth = DateTime.DaysInMonth(2017, _month);
            //if (_month.Equals(2))
            //{
            //    daysInMonth = 28;
            //}

            var iteration = 1;
            var day = 1;
            foreach (Match match in Regex.Matches(line, Pattern))
            {
                var replacment = @"Date(" + TimeInUnix(day) + ")";
                line = ReplaceAt(line, match.Index, 19, replacment);
                if (iteration > 6)
                {
                    iteration = 1;
                    day++;
                }
                iteration++;

                if (day.Equals(daysInMonth))
                {
                    break;
                }

            }
            WriteStringToFile(line);
        }
     
        public static string ReplaceAt(string str, int index, int length, string replace)
        {
            return str.Remove(index,length)
                    .Insert(index, replace);
        }

        public static void WorkWithConsole()
        {
            Console.WriteLine("Please entert month of year 2017");
            _month = Convert.ToInt32(Console.ReadLine());
            if (0 < _month || _month > 12)
            {
                Console.WriteLine("Try again");
                WorkWithConsole();
            }
        }

        public static string TimeInUnix(int day)
        {
            var timeUtc = new DateTime(2017, _month, day, 0, 0, 0, 0, DateTimeKind.Utc) -
                              new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var unixTime = timeUtc.TotalSeconds * 1000;
            var unixTimeString = unixTime.ToString(CultureInfo.CurrentCulture);
            return unixTimeString;
        }

        public static void WriteStringToFile(string output)
        {
            string monthtostring;
            if (_month < 9)
                monthtostring = 0 + _month.ToString();
            else
                monthtostring = _month.ToString();

            var outputFile = new StreamWriter(@"MonthChallenges" + monthtostring + "17.js");
            outputFile.WriteLine(output);

            outputFile.Flush();
            outputFile.Close();
        }

        public static string ReadFileToString(string file)
        {
            var line = string.Empty;
            try
            {
                using (var sr = new StreamReader(file, true))
                {
                    line = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return line;
        }
    }

}