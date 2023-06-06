using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.GenericList
{
    public class NormalClassButGenericMethod
    {
        //Making the Method as Generic by using the <T1, T2> 
        //Then using T1 and T2 as parameters of the method
        public void GenericMethod<T1, T2>(T1 Param1, T2 Param2)
        {
            Console.WriteLine($"Parameter T1 type: {typeof(T1)}: Parameter T2 type: {typeof(T2)}");
            Console.WriteLine($"Parameter 1: {Param1} : Parameter 2: {Param2}");
        }
    }

    
    
}


/**
 * 
 * 
 * class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic Method Example in C#");
            SomeClass s = new SomeClass();
            //While calling the method we need to specify the type for both T1 and T2
            s.GenericMethod<int, int>(10, 20);
            s.GenericMethod<double, string>(10.5, "Hello");
            s.GenericMethod<string, float>("Anurag", 20.5f);
            Console.ReadLine();
        }
    }
 * 
 */
*