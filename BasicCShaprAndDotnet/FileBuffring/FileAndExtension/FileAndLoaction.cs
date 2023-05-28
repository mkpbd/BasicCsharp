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

        // Append all  line 

        public void FileAppendAllText()
        {
            string path = @"F:\Jallal\Files\MyTest2.txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string createText = "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(path, createText);
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            string appendText = "This is extra text" + Environment.NewLine;
            File.AppendAllText(path, appendText);

            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }




        public void FileEncrypt()
        {
            try
            {
                string FileName = "test.txt";

                Console.WriteLine("Encrypt " + FileName);

                // Encrypt the file.
                AddEncryption(FileName);

                Console.WriteLine("Decrypt " + FileName);

                // Decrypt the file.
                RemoveEncryption(FileName);

                Console.WriteLine("Done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }


        // Encrypt a file.
        public static void AddEncryption(string FileName)
        {

            File.Encrypt(FileName);
        }

        // Decrypt a file.
        public static void RemoveEncryption(string FileName)
        {
            File.Decrypt(FileName);
        }



        public void FileStreaming()
        {
            string path = @"F:\Jallal\Files\MyTest3.txt";

            // Delete the file if it exists.
            if (File.Exists(path))
            {
                File.Delete(path);
            }


            //Create the file.
            using (FileStream fs = File.Create(path))
            {
                AddText(fs, "This is some text");
                AddText(fs, "This is some more text,");
                AddText(fs, "\r\nand this is on a new line");
                AddText(fs, "\r\n\r\nThe following is a subset of characters:\r\n");

                for (int i = 1; i < 120; i++)
                {
                    AddText(fs, Convert.ToChar(i).ToString());
                }
            }

            //Open the stream and read it back.
            using (FileStream fs = File.OpenRead(path))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                int readLen;
                while ((readLen = fs.Read(b, 0, b.Length)) > 0)
                {
                    Console.WriteLine(temp.GetString(b, 0, readLen));
                }
            }
        }


        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }



        public async void Button_Click()
        {
            UnicodeEncoding uniencoding = new UnicodeEncoding();
            string filename = @"F:\Jallal\Files\userinputlog.txt";

            byte[] result = uniencoding.GetBytes("Hello welcome in Bangladesh");

            using (FileStream SourceStream = File.Open(filename, FileMode.OpenOrCreate))
            {
                SourceStream.Seek(0, SeekOrigin.End);
                await SourceStream.WriteAsync(result, 0, result.Length);
            }
        }



    }

}
