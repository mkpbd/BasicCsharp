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


    }
}
