using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileSystems.FilesFormat
{
    public class FileOne
    {

        /**
         * 
         * Provides static methods for the creation, copying, deletion, moving, and opening of asingle file, and aids in the creation of FileStream objects
         */

        string path = @"F:\Jallal\Files\MyTest.txt"
;


        public void FileAccessMod() {
            FileStream s2 = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);

        }


        public void CreateFileAndInsertData()
        {

            if (!File.Exists(path))
            {

                // Create a file to write to.
                using
                (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(
                    "Hello"
                    );
                    sw.WriteLine(
                    "And"
                    );
                    sw.WriteLine(
                    "Welcome"
                    );


                    Console.WriteLine( "File create and data inserted now");
                }

            }

        }


        public void FileReadAndClose()
        {

            if (!File.Exists(path))
            {
                Console.WriteLine(  "No file found currnet Path = "+ path);
                return;
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string
                s;
                while
                ((s = sr.ReadLine()) !=
                null
                )
                {
                    Console.WriteLine(s);
                }
            }

        }


        public void FileAttributesGetAccessMode()
        {
            FileAttributes attributes = File.GetAttributes(path);
            if
            ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                Console.WriteLine(
                "read-only file"
                );
            }
            else
            {
                Console.WriteLine(
                "not read-only file"
                );
            }
        }




    }
}
