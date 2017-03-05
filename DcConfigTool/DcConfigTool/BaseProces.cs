using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace DcConfigTool
{
    public class BaseProces
    {
        private const string Pattern = @"Date\(\d{13}\)";
        private static int _month = InputParam.MonthSet;
        public static bool Generate()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");


            var line = ReadFileToString(InputParam.FilePath);



            var configChallanges = 0;
            if (InputParam.GameTypeSet == InputParam.GameType.Solitaire) configChallanges = 6;
            if (InputParam.GameTypeSet == InputParam.GameType.Mahjong) configChallanges = 1;


            if (InputParam.Yeargenerator)
            {
                for (int i = 1; i <= 12; i++)
                {
                    _month = i;     
                    workWithFile(line, configChallanges);
                }
            }
            else
            {
                workWithFile(line, configChallanges);
            }
            return true;
        }

        public static string ReplaceAt(string str, int index, int length, string replace)
        {
            return str.Remove(index, length)
                    .Insert(index, replace);
        }


        public static string TimeInUnix(int day)
        {

            var timeUtc = new DateTime(InputParam.YaerSet, _month, day, 0, 0, 0, 0, DateTimeKind.Utc) -
                              new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var unixTime = timeUtc.TotalSeconds * 1000;
            var unixTimeString = unixTime.ToString(CultureInfo.CurrentCulture);
            return unixTimeString;
        }

        public static void WriteStringToFile(string output)
        {
            string monthtostring;
            if (_month <= 9)
                monthtostring = 0 + _month.ToString();
            else
                monthtostring = _month.ToString();
            var outputfilename = @"MonthChallenges" + monthtostring + InputParam.YaerSet.ToString().TrimStart('2', '0') + ".js";
            var outputFolder = InputParam.OutputPath+"\\" + outputfilename + "\\1\\";
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }

            var outputFile = new StreamWriter(outputFolder+outputfilename);
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
                //Console.WriteLine("The file could not be read:");
                // Console.WriteLine(e.Message);
            }
            return line;
        }

        private static void workWithFile(string line, int configChallanges)
        {
            var iteration = 1;
            var day = 1;
            int daysInMonth = DateTime.DaysInMonth(InputParam.YaerSet, _month);
            foreach (Match match in Regex.Matches(line, Pattern))
            {
                var replacment = @"Date(" + TimeInUnix(day) + ")";
                line = ReplaceAt(line, match.Index, 19, replacment);
                if (iteration > configChallanges)
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


    }
}