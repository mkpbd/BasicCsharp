using System;
using System.Collections.Generic;
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
            int number = await Task.FromResult( 55);
            return number;
        }
    }
}
