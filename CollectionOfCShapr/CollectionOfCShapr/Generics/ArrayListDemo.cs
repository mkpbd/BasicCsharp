using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfCShapr.Generics
{
    public class ArrayListDemo
    {

        public void ArrayListMethod()
        {
            //Adding elements to ArrayList using Add() method
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(101); //Adding Integer Value
            arrayList1.Add("James"); //Adding String Value
            arrayList1.Add("James"); //Adding Duplicate Value
            arrayList1.Add(" "); //Adding Empty
            arrayList1.Add(true); //Adding Boolean
            arrayList1.Add(4.5); //Adding double
            arrayList1.Add(null); //Adding null
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            //Adding Elements to ArrayList using object initializer syntax
            var arrayList2 = new ArrayList()
            {
                102, "Smith", "Smith", true, 15.6
            };
            foreach (var item in arrayList2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }



        public void ArrayListMethod2()
        {
            //Adding elements to ArrayList using Add() method
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(101); //Adding Integer Value
            arrayList1.Add("James"); //Adding String Value
            arrayList1.Add(true); //Adding Boolean
            arrayList1.Add(4.5); //Adding double
            //Accessing individual elements from ArrayList using Indexer
            int firstElement = (int)arrayList1[0]; //returns 101
            string secondElement = (string)arrayList1[1]; //returns "James"
            //int secondElement = (int) arrayList1[1]; //Error: cannot cover string to int
            Console.WriteLine($"First Element: {firstElement}, Second Element: {secondElement}");
            //Using var keyword without explicit casting
            var firsItem = arrayList1[0]; //returns 101
            var secondItem = arrayList1[1]; //returns "James"
            //var fifthElement = arrayList1[5]; //Error: Index out of range
            Console.WriteLine($"First Item: {firsItem}, Second Item: {secondItem}");
            //update elements
            arrayList1[0] = "Smith";
            arrayList1[1] = 1010;
            //arrayList1[5] = 500; //Error: Index out of range
            foreach (var item in arrayList1)
            {
                Console.Write($"{item} ");
            }

        }


        public void ArrayListIterating()
        {

            //Adding elements to ArrayList using Add() method
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(101); //Adding Integer Value
            arrayList1.Add("James"); //Adding String Value
            arrayList1.Add(true); //Adding Boolean
            arrayList1.Add(4.5); //Adding double
            //Iterating through foreach loop
            Console.WriteLine("Using ForEach Loop");
            foreach (var item in arrayList1)
            {
                Console.Write($"{item} ");
            }
            //Iterating through for loop
            Console.WriteLine("\n\nUsing For Loop");
            for (int i = 0; i < arrayList1.Count; i++)
            {
                Console.Write($"{arrayList1[i]} ");
            }
            Console.ReadKey();
        }



        public void InserElement()
        {
            ArrayList arrayList = new ArrayList()
            {
                    101,
                    "James",
                    true,
                    10.20
            };

            //Insert "First Element" at First Position i.e. Index 0
            arrayList.Insert(0, "First Element");
            //Insert "Third Element" at Third Position i.e. Index 2
            arrayList.Insert(2, "Third Element");
            //Iterating through foreach loop
            foreach (var item in arrayList)
            {
                Console.WriteLine($"{item}");
            }
            Console.ReadKey();
        }


        public void InserIntoRage()
        {
            ArrayList arrayList1 = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Nepal"
            };
            Console.WriteLine("Array List Elements");
            foreach (var item in arrayList1)
            {
                Console.Write($"{item} ");
            }
            ArrayList arrayList2 = new ArrayList()
            {
                    "Srilanka",
                    "Japan",
                    "Britem"
            };
            arrayList1.InsertRange(2, arrayList2);

            Console.WriteLine("\n\nArray List Elements After InsertRange");
            foreach (var item in arrayList1)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }


        public void RemoveElement()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Nepal",
                    "HongKong",
                    "Srilanka",
                    "Japan",
                    "Britem",
                    "HongKong",
            };
            Console.WriteLine("Array List Elements");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            arrayList.Remove("HongKong"); //Removes first occurance of null
            Console.WriteLine("\n\nArray List Elements After Removing First Occurances of HongKong");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            arrayList.RemoveAt(3); //Removes element at index postion 3, it is 0 based index
            Console.WriteLine("\n\nArray List1 Elements After Removing Element from Index 3");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            arrayList.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
            Console.WriteLine("\n\nArray List Elements After Removing First Two Elements");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }


        public void AllClerOrRemove()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Denmark",
                    "Nepal",
            };
            int totalItems = arrayList.Count;
            Console.WriteLine(string.Format($"Total Items: {totalItems}, Capacity: {arrayList.Capacity}"));
            //Remove all items from the Array list             
            arrayList.Clear();
            totalItems = arrayList.Count;
            Console.WriteLine(string.Format($"Total Items After Clear(): {totalItems}, Capacity: {arrayList.Capacity}"));
            Console.ReadKey();

        }

    }
}
