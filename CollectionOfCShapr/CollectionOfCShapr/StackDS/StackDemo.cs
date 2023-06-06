using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfCShapr.StackDS
{
    public class StackDemo
    {

        public void StackCollection()
        {

            // Creating a stack collection
            Stack stack = new Stack();

            //Adding item to the stack using the push method
            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14f);
            stack.Push(true);
            stack.Push(67.8);
            stack.Push('A');

            //Printing the stack items using foreach loop
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }


        public void ShowAndReomove()
        {
            // Creating a stack collection
             Stack stack = new Stack();
            //Adding item to the stack using the push method
            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14f);
            stack.Push(true);
            stack.Push(67.8);
            stack.Push('A');
            //Printing the stack items using foreach loop
            Console.WriteLine($"All Stack Elements: Count {stack.Count}");
            foreach (var item in stack)
            {
                Console.Write($"{item} ");
            }
            //Removing and Returning an item from the stack using the pop method
            Console.WriteLine($"\n\nDeleted Element: {stack.Pop()}");
            //Printing item after removing the last added item
            Console.WriteLine($"\nAll Stack Elements After Deletion: Count {stack.Count}");
            foreach (var item in stack)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }


        public void TotalElement()
        {
            // Creating a stack collection
            Stack stack = new Stack();
            //Adding item to the stack using the push method
            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14f);
            stack.Push(true);
            stack.Push(67.8);
            stack.Push('A');
            Console.WriteLine($"Total elements present in stack : {stack.Count}");
            // Fetch the topmost element of stack Using Pop method
            Console.WriteLine($"Topmost element of stack is {stack.Pop()}");
            Console.WriteLine($"Total elements present in stack : {stack.Count}");
            // Fetch the topmost element from Stacj Using Peek method
            Console.WriteLine($"Topmost element of Stack is {stack.Peek()}");
            Console.WriteLine($"Total elements present in stack : {stack.Count}");
            Console.ReadKey();
        }


        public void CheckInStack()
        {
            // Creating a stack collection
            Stack stack = new Stack();
            //Adding item to the stack using the push method
            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14f);
            stack.Push(true);
            stack.Push(67.8);
            stack.Push('A');
            // Checking if the element Hello is present in the Stack or not
            if (stack.Contains("Hello"))
            {
                Console.WriteLine("Element Hello is found");
            }
            else
            {
                Console.WriteLine("Element Hello is not found");
            }
            // Checking if the element Hello is present in the Stack or not
            if (stack.Contains("World"))
            {
                Console.WriteLine("Element World is found");
            }
            else
            {
                Console.WriteLine("Element World is not found");
            }
            Console.ReadKey();
        }


        public void PrintingStack()
        {
            // Creating a stack collection
            Stack stack = new Stack();
            //Adding item to the stack using the push method
            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14f);
            stack.Push(67.8);
            //Printing All Stack Elements using For Each Loop
            Console.WriteLine("Stack Elements:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            //Creating a clone queue using Clone method
            Stack cloneStack = (Stack)stack.Clone();
            Console.WriteLine("\nCloned Stack Elements:");
            foreach (var item in cloneStack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
