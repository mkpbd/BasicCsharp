using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystems.FilesFormat
{
    public class FileInfoes
    {

        string path = Path.GetTempFileName();


        // Create a file to write to.

        public void CreateFile()
        {

            var fi1 = new FileInfo(path);

            using (StreamWriter sw = fi1.CreateText())
            {
                sw.WriteLine(  "Hello" );
                sw.WriteLine( "And" );
               // This example produces output similar to the following.
                sw.WriteLine("Welcome");
            }
        }


        // Open the file to read from.
        public void  OpenAndReadFile()
        {
            var fi1 = new FileInfo(path);

            // Open the file to read from.
            using
            (StreamReader sr = fi1.OpenText())
            {
                var    s =  ""  ;
                while ((s = sr.ReadLine()) !=  null   )
                {
                    Console.WriteLine(s);
                }
            }
        }


        public void DeleteExistsFiles()
        {

            try
            {
                var fi1 = new FileInfo(path);
                string path2 = Path.GetTempFileName();
                var fi2 =  new     FileInfo(path2);
                // Ensure that the target does not exist.
                fi2.Delete();
                // Copy the file.
                fi1.CopyTo(path2);
                Console.WriteLine(    $"{ path}  was copied to{ path2}.");
                // Delete the newly created file.
                fi2.Delete();
                Console.WriteLine(
                $"{ path2}   was successfully deleted.");
            }
            catch (Exception e)
            {
                Console.WriteLine(  $"The process failed: { e.ToString()} ");
            }
        }



        public void FileInfoConstructor()
        {
            // Open an existing file, or create a new one.
            FileInfo fi =
            new
            FileInfo( "temp.txt" );
            // Create a writer, ready to add entries to the file.
            StreamWriter sw = fi.AppendText();
            sw.WriteLine(    "This is a new entry to add to the file"   );
            sw.WriteLine(  "This is yet another line to add..."   );
            sw.Flush();
            sw.Close();
            // Get the information out of the file and display it.
            StreamReader sr =
            new
            StreamReader(fi.OpenRead());
            while  (sr.Peek() !=  -1  )
                Console.WriteLine(sr.ReadLine());
        }

    }
}
