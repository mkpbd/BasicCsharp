using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace FileSystems.FilesFormat
{
    public class FileExample
    {
        public static void GetFilesPath()
        {
            string FileName = @"c:\test.xml";
            // Get the read-only value for a file.
            bool isReadOnly = IsFileReadOnly(FileName);
            // Display wether the file is read-only.
            Console.WriteLine("The file read-only value for " + FileName + " is: " + isReadOnly);
            Console.WriteLine("Changing the read-only value for " + FileName + " to true.");
            // Set the file to read-only.
            SetFileReadAccess(FileName, true);
            // Get the read-only value for a file.
            isReadOnly = IsFileReadOnly(FileName);
            // Display that the file is read-only.
            Console.WriteLine(
            "The file read-only value for "
            + FileName +
            " is: "
            + isReadOnly);
        }
        // Sets the read-only value of a file.
        public static void SetFileReadAccess(string FileName, bool SetReadOnly)
        {
            // Create a new FileInfo object.
            FileInfo fInfo =
            new
            FileInfo(FileName);
            // Set the IsReadOnly property.
            fInfo.IsReadOnly = SetReadOnly;
        }
        // Returns wether a file is read-only.
        public static bool IsFileReadOnly(string FileName)
        {
            // Create a new FileInfo object.
            // Create a new FileInfo object.
            FileInfo fInfo = new FileInfo(FileName);

            // Return the IsReadOnly property value.
            return fInfo.IsReadOnly;
        }



        public void GetFileLength()
        {
            // Make a reference to a directory.
            DirectoryInfo di = new DirectoryInfo("c:\\");
            // Get a reference to each file in that directory.
            FileInfo[] fiArr = di.GetFiles();
            // Display the names and sizes of the files.
            Console.WriteLine("The directory {0} contains the following files:", di.Name);
            foreach (FileInfo f in fiArr)
                Console.WriteLine("The size of {0} is {1} bytes.", f.Name, f.Length);
        }


        public void NameTest()
        {
            // Create a reference to the current directory.
            DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory);
            // Create an array representing the files in the current directory.
            FileInfo[] fi = di.GetFiles();
            Console.WriteLine("The following files exist in the current directory:");
            // Print out the names of the files in the current directory.
            foreach (FileInfo fiTemp in fi)
                Console.WriteLine(fiTemp.Name);
        }


        public void AppendsText()
        {

            FileInfo fi = new FileInfo(@"c:\MyTest.txt");
            // This text is added only once to the file.
            if (!fi.Exists)
            {
                //Create a file to write to.
                using (StreamWriter sw = fi.CreateText())
                {
                    sw.WriteLine(
                    "Hello"
                    );
                    //    The following example demonstrates appending text to the end of a file and alsodisplays the result of the append operation to the console.The first time this routine iscalled, the file is created if it does not exist.After that, the specified text is appended tothe file.
                    sw.WriteLine(
                    "And"
                    );
                    sw.WriteLine(
                    "Welcome"
                    );
                }
            }

            // This text will always be added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = fi.AppendText())
            {
                sw.WriteLine("This");
                sw.WriteLine("is Extra");
                sw.WriteLine("Text");
            }
            //Open the file to read from.
            using (StreamReader sr = fi.OpenText())
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }



    }

}
