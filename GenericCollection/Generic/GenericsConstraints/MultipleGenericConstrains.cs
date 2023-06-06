using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.GenericsConstraints
{
    public class MultipleGenericConstrains<T, X> where T : class where X : struct
    {
        public T Message;
        public void GenericMethod(T Param1, X Param2)
        {
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Param1: {Param1}");
            Console.WriteLine($"Param2: {Param2}");
        }
    }


}


/***
 * 
 * 
 * class Program
    {
        static void Main()
        {
            MultipleGenericConstrains<string, int> multipleGenericConstraints = new MultipleGenericConstrains<string, int>();
            multipleGenericConstraints.Message = "Good Morning";
            multipleGenericConstraints.GenericMethod("Anurag", 100);
            Console.ReadKey();
        }
    }
 * 
 * 
 * 
 * ***/