using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystems.FilesFormat
{
    public class DirectoryTest
    {

        public void GetPathFileDirectory()
        {
            // Open an existing file, or create a new one.
            FileInfo fi = new FileInfo("temp.txt");
            // Determine the full path of the file just created.
            DirectoryInfo di = fi.Directory;
            // Figure out what other entries are in that directory.
            FileSystemInfo[] fsi = di.GetFileSystemInfos();
            Console.WriteLine("The directory '{0}' contains the following files and directories:", di.FullName);
            // Print the names of all the files and subdirectories of that directory.
            foreach (FileSystemInfo info in fsi)
                Console.WriteLine(info.Name);
        }



        public byte[] OpenDataFile(string FileName)
        {
            // Check the FileName argument.
            if
            (FileName == null || FileName.Length == 0)
            {
                throw new ArgumentNullException("FileName");
            }
            // Check to see if the file exists.
            FileInfo fInfo =
            new
            FileInfo(FileName);
            // You can throw a personalized exception if
            // the file does not exist.
            if
            (!fInfo.Exists)
            {
                throw new FileNotFoundException("The file was not found.", FileName);
            }


            // Open the file.
            FileStream fStream = new FileStream(FileName, FileMode.Open);
            // Create a buffer.
            byte[] buffer = new byte[fStream.Length];
            // Read the file contents to the buffer.
            fStream.Read(buffer, 0, (int)fStream.Length);
            // return the buffer.
            return buffer;
        }



    }
}
