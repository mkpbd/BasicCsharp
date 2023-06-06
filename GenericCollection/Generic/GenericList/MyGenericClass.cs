using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.GenericList
{
    //MyGenericClass is a Generic Class
    //Here T specifies the Data Types of the class Members
    public class MyGenericClass<T>
    {

        //Generic variable
        //The data type is generic i.e. T
        private T GenericMemberVariable;
        //Generic Constructor
        //Constructor accepts one parameter of Generic type i.e. T
        public MyGenericClass(T value)
        {
            GenericMemberVariable = value;
        }
        //Generic Method
        //Method accepts one Generic type Parameter i.e. T
        //Method return type also Generic i.e. T
        public T GenericMethod(T GenericParameter)
        {
            Console.WriteLine($"Parameter type: {typeof(T).ToString()}, Value: {GenericParameter}");
            Console.WriteLine($"Return type: {typeof(T).ToString()}, Value: {GenericMemberVariable}");
            return GenericMemberVariable;
        }
        //Generic Property
        //The data type is generic i.e. T
        public T GenericProperty { get; set; }
    }
}
