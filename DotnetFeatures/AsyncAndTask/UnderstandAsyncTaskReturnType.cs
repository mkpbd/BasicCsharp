using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AsyncAndTask
{
    internal class UnderstandAsyncTaskReturnType
    {
        /****
         * 
         * 
         * Asynchronous programming in modern languages like C# has introduced various return value types to represent the outcomes of asynchronous operations. In this article, we will explore and explain the different return value types in async methods, including
         * 
         * 
         * 
         * 
         * async Task
         * async Task<TResult>
         * async void
         * async ValueTask<TResult>
         * and async IAsyncEnumerable<T>
         * ****/


        // 1. Async Task


        //The async Task return type is used when an asynchronous method doesn't need to produce a result. It represents a fire-and-forget operation or a task that doesn't require explicit awaiting
        public async Task PerformanceValueNoValueIsReturn()
        {
            // Perform async operation here

            Task.Delay(1000);
            //await Console.Out.WriteLineAsync("Hello kamal passa");
            await Task.FromResult<string>("Hello kamal");
        }


        //2.async Task<TResult>:

        //The async Task<TResult> return type is used when an asynchronous method needs to produce a result of type TResult.It represents an asynchronous operation that will eventually provide a result.Here's an example:
        public async Task<int> GetNumberAsync()
        {
            // Perform async operation to retrieve a number
            int number = await Task.FromResult(55);
            return number;
        }

        //        3. async void:
        //The async void return type is used when an asynchronous method doesn't need to return a result or be awaited explicitly. It is commonly used for event handlers or when the calling code doesn't require the task's completion. Here's an example:

        public async void ProcessDataAsync()
        {
            // Perform async data processing
            await Task.FromResult("making Mony");
            // Additional processing or handling
        }



        //        4. async ValueTask<TResult>:
        //The async ValueTask<TResult> return type is suitable for lightweight asynchronous operations that produce a result.It offers performance benefits by reducing unnecessary allocations.Here's an example:

        public async ValueTask<string> GetStringAsync()
        {
            // Perform lightweight async operation to retrieve a string
            string result = await SomeLightweightOperation();
            return result;
        }

        //In this example, the 📢 GetStringAsync method returns ValueTask<string>, representing a lightweight asynchronous operation that will eventually produce a string result.

        public async Task<string> SomeLightweightOperation()
        {
            return "hello bangaldesh";
        }


        //        5. async IAsyncEnumerable<T>:
        //The async IAsyncEnumerable<T> return type is used to represent a sequence of asynchronous values that can be iterated asynchronously.It is part of the asynchronous streams feature introduced in C# 8.0. Here's an example:
        public async IAsyncEnumerable<int> GenerateNumbersAsync()
        {
            // Generate a sequence of numbers asynchronously
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }

        //in this example, the 📢 GenerateNumbersAsync method returns IAsyncEnumerable<int>, enabling the consumption of a sequence of asynchronously generated numbers.
    }
}
