using Generic.GenericList;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<string> stringGenericClass = new MyGenericClass<string>("Hello Generic World");
            stringGenericClass.GenericProperty = "This is a generic property example.";
            string result = stringGenericClass.GenericMethod("Generic Parameter");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}