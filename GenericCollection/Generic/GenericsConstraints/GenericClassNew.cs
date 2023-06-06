using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.GenericsConstraints
{
    internal class GenericClassNew<T> where T : new
    {
        public T Message;
        public void GenericMethod(T Param1, T Param2)
        {
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Param1: {Param1}");
            Console.WriteLine($"Param2: {Param2}");
        }
    }
}
