using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfCShapr.Generics
{
    public static class ArrayListForNongeneric
    {

        public static void ArrayLists()
        {

            ArrayList listOfArray = new ArrayList();
            listOfArray.Add("kamal");
            listOfArray.Add("jamal");
            listOfArray.Add(100);
            listOfArray.Add(true);
            listOfArray.Add(10.5f);


            foreach (var item in listOfArray)
            {
                Console.WriteLine(  item + " \n");
            }
        }


        public static void SahTables()
        {

            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "kamal");
            hashtable.Add(2, "jamal");
            hashtable.Add(3, "totmal");
            hashtable.Add(4, 100);


            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine( item.Key + " "+ item.Value);
            }

        }

        public static void SortedListOrder()
        {
            SortedList sl = new SortedList();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (DictionaryEntry d in sl)
            {
                Console.Write(d.Key + " " + d.Value);
                Console.Write("<br>");
            }
        }




    }
}
