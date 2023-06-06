using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.GenericList
{
    public class GenericClass<T>
    {
        // T is  type Generice 
        // now we can use any type when  object instatiate 
        public T Message;
        public void GenericMethod(T Name, T Location)
        {
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Location: {Location}");
        }
    }
}
