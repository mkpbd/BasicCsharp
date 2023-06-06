using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfCShapr.GenericListDemo
{
    public class GenericListDemo
    {
        public void ListGeneric() {
            List<int> integerList = new List<int>();
            integerList.Add(11);
            integerList.Add(22);
            integerList.Add(55);
            integerList.Add(65);
            integerList.Add(10);
            //The following line give you compile time error as the value is string
            //integerList.Add("Hello");
            Console.Write("List of Elements: ");
            foreach (int item in integerList)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }


        public void HashSetGeneric()
        {
            HashSet<int> integerHashSet = new HashSet<int>();
            integerHashSet.Add(11);
            integerHashSet.Add(22);
            integerHashSet.Add(55);
            integerHashSet.Add(65);
            //Addind Duplicate Elements
            integerHashSet.Add(55);
            //The following line give you compile time error as the value is string
            //integerHashSet.Add("Hello");
            Console.Write("List of Elements: ");
            foreach (int item in integerHashSet)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }


        public void SortedSet()
        {
            SortedSet<int> integerSortedSet = new SortedSet<int>();
            integerSortedSet.Add(11);
            integerSortedSet.Add(66);
            integerSortedSet.Add(55);
            integerSortedSet.Add(88);
            integerSortedSet.Add(22);
            integerSortedSet.Add(77);
            //Addind Duplicate Elements
            integerSortedSet.Add(55);
            //The following line give you compile time error as the value is string
            //integerSortedSet.Add("Hello");
            Console.WriteLine("List of Elements of SortedSet:");
            foreach (int item in integerSortedSet)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }


        public void StackGen()
        {
            Stack<string> countriesStack = new Stack<string>();
            countriesStack.Push("India");
            countriesStack.Push("USA");
            countriesStack.Push("UK");
            countriesStack.Push("China");
            countriesStack.Push("Nepal");
            Console.WriteLine("Stack Elements: ");
            foreach (string country in countriesStack)
            {
                Console.Write($"{country} ");
            }
            Console.WriteLine("\n\nPeek Element: " + countriesStack.Peek());
            Console.WriteLine("Element Popped: " + countriesStack.Pop());
            Console.WriteLine("\nStack Elements: ");
            foreach (string country in countriesStack)
            {
                Console.Write($"{country} ");
            }
            Console.ReadKey();
        }


        public void QueueGen()
        {
            Queue<string> countriesQueue = new Queue<string>();
            countriesQueue.Enqueue("India");
            countriesQueue.Enqueue("USA");
            countriesQueue.Enqueue("UK");
            countriesQueue.Enqueue("China");
            countriesQueue.Enqueue("Nepal");
            Console.WriteLine("Queue Elements: ");
            foreach (string country in countriesQueue)
            {
                Console.Write($"{country} ");
            }
            Console.WriteLine("\n\nPeek Element: " + countriesQueue.Peek());
            Console.WriteLine("Element Removed: " + countriesQueue.Dequeue());
            Console.WriteLine("\nQueue Elements: ");
            foreach (string country in countriesQueue)
            {
                Console.Write($"{country} ");
            }
            Console.ReadKey();
        }


        public void DictornaryGen()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");
            dictionary.Add(4, "Four");
            dictionary.Add(5, "Five");
            Console.WriteLine("Dictionary Elements: ");
            foreach (KeyValuePair<int, string> kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
            Console.ReadKey();
        }


        public void DictornarySortedGen()
        {
            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();
            sortedDictionary.Add(1, "One");
            sortedDictionary.Add(5, "Five");
            sortedDictionary.Add(2, "Two");
            sortedDictionary.Add(4, "Four");
            sortedDictionary.Add(3, "Three");

            Console.WriteLine("SortedDictionary Elements: ");
            foreach (KeyValuePair<int, string> kvp in sortedDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
            Console.ReadKey();
        }


        public void SortedListGen()
        {
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(1, "One");
            sortedList.Add(5, "Five");
            sortedList.Add(2, "Two");
            sortedList.Add(4, "Four");
            sortedList.Add(3, "Three");

            Console.WriteLine("SortedList Elements: ");
            foreach (KeyValuePair<int, string> kvp in sortedList)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
            Console.ReadKey();
        }


        public void LinkListGen()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("One");
            linkedList.AddLast("Two");
            linkedList.AddLast("Three");
            linkedList.AddLast("Four");
            linkedList.AddFirst("Five"); //Added to first index
            Console.WriteLine("SortedDictionary Elements: ");
            foreach (var item in linkedList)
            {
                Console.WriteLine($"{item} ");
            }
            Console.ReadKey();
        }


    }
}
