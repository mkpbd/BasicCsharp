using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBuffring.FileAndExtension
{
    public  class FileAtributesPermission
    {


        public void FileAttributesPermissions()
        {
            FileAttributes attributes = File.GetAttributes("F:\\Jallal\\Files\\MyTest.txt");
            if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                Console.WriteLine("read-only file");
            }
            else
            {
                Console.WriteLine("not read-only file");
            }
        }
    }
}
