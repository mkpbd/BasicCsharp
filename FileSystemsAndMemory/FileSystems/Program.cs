using FileSystems.FilesFormat;

namespace FileSystems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fl = new FileOne();

            //fl.CreateFileAndInsertData();
            fl.FileReadAndClose();



           Console.ReadKey();
        }
    }
}