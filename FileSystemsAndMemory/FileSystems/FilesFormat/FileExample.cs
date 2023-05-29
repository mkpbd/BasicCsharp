using System;
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
    }

}
