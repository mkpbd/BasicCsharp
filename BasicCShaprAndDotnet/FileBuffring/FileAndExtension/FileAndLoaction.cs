using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBuffring.FileAndExtension
{
    public class FileAndLoaction
    {
        static string dataPath = @"F:\Jallal\Files\timestamps.txt";
        public void FileCreateIsNotExistes()
        {
            string path = @"F:\Jallal\Files\MyTest.txt";

            if (!File.Exists(path))
            {
                // Create a file to write to.

                using(StreamWriter sw = File.CreateText(path)){
                        
                    sw.Write("Hello Kamal passa Are your ready");
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }
        }

        // open file is exist  and read file data

        public void ReadFileIFExist()
        {
            string path = @"F:\Jallal\Files\MyTest.txt";

            if (File.Exists(path))
            {
                // Open the file to read from.
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

        }


        public void AppendAllLinesByFile()
        {

            CreateSampleFile();

            var JulyWeekends = from line in File.ReadLines(dataPath)
                               where (line.StartsWith("Saturday") ||
                               line.StartsWith("Sunday")) &
                               line.Contains("July")
                               select line;

            File.WriteAllLines(@"F:\Jallal\Files\selectedDays.txt", JulyWeekends);

            var MarchMondays = from line in File.ReadLines(dataPath)
                               where line.StartsWith("Monday") &&
                               line.Contains("March")
                               select line;

            File.AppendAllLines(@"F:\Jallal\Files\selectedDays.txt", MarchMondays);

        }

        static void CreateSampleFile()
        {
            DateTime TimeStamp = new DateTime(1700, 1, 1);

            using (StreamWriter sw = new StreamWriter(dataPath))
            {
                for (int i = 0; i < 500; i++)
                {
                    DateTime TS1 = TimeStamp.AddYears(i);
                    DateTime TS2 = TS1.AddMonths(i);
                    DateTime TS3 = TS2.AddDays(i);
                    sw.WriteLine(TS3.ToLongDateString());
                }
            }
        }
    }
}
