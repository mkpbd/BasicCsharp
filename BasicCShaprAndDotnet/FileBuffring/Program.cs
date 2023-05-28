

using FileBuffring.FileAndExtension;

namespace FileBuffring
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var fileloaction = new FileAndLoaction();
            //fileloaction.FileCreateIsNotExistes();
            //fileloaction.ReadFileIFExist();
            fileloaction.AppendAllLinesByFile();


        }
    }
}