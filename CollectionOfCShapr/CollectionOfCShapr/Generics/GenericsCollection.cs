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


        public static void GenericList()
        {
            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);
            lst.Add(400);
            foreach (int i in lst)
            {
                Console.Write(i + "<br>");
            }
        }


        public static void GenericDictonary()
        {
            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "cs.net");
            dct.Add(2, "vb.net");
            dct.Add(3, "vb.net");
            dct.Add(4, "vb.net");
            foreach (KeyValuePair<int, string> kvp in dct)
            {
                Console.Write(kvp.Key + " " + kvp.Value);
                Console.Write("<br>");
            }
        }

        public static void GenericStack() {

            Stack<string> stk = new Stack<string>();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sqlserver");

            foreach (string s in stk)
            {
                Console.Write(s + "<br>");
            }

        }



        public static void GenericQueue()
        {
            Queue<string> q = new Queue<string>();

            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");

            foreach (string s in q)
            {
                Console.Write(s + "<br>");
            }
        }


        public static void GenericShashSet()
        {
            var shah = new HashSet<int>();
            shah.Add(1);
            shah.Add(2);
                
            shah.Add(3);
            shah.Add(2);
            shah.Add(3);
            shah.Add(4);
            shah.Add(5);
            shah.Add(6);

            
        }

        public static void GenericSortedList() {
          var slist =  new SortedList<int, string>();
            slist.Add(1, "jamal");
            slist.Add(5, "af");
            slist.Add(3, "cc");
            slist.Add(1, "ee");
            slist.Add(4, "romal");
            slist.Add(2, "tomal");
           
        }
    }
}
