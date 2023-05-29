namespace AsyncAndTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var asynceTask = new UnderstandAsyncTaskReturnType();
            //var restult = asynceTask.PerformanceValueNoValueIsReturn();
            //Console.WriteLine( restult.Result);
            //var restult = asynceTask.GetNumberAsync();
            var restult = asynceTask.GetStringAsync();

            Console.WriteLine(restult.Result); ;
        }
    }
}