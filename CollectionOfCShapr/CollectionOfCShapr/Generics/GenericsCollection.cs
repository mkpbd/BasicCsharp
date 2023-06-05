using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfCShapr.Generics
{
    public class GenericsCollection
    {

        public static void StackOfMemory()
        {
            Stack stk = new Stack();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sqlserver");

            foreach (object o in stk)
            {
                Console.Write(o + "<br>");
            }
        }


        public static void HeapOfQueue()
        {
            Queue q = new Queue();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");

            foreach (object o in q)
            {
                Console.Write(o + "<br>");
            }
        }
    }
}
