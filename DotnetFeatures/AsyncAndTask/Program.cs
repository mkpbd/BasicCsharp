namespace AsyncAndTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var asynceTask = new UnderstandAsyncTaskReturnType();
           //var restult = asynceTask.PerformanceValueNoValueIsReturn();
           var restult = asynceTask.GetNumberAsync();

            Console.WriteLine(restult); ;
        }
    }
}