using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfCShapr.Hashtables
{
    public class HashtableDemo
    {

        public void HashtableAdd()
        {
            //Creating Hashtable collection with default constructor
            Hashtable hashtable = new Hashtable();
            //Adding elements to the Hash table using key value pair
            hashtable.Add("EId", 1001); //Here key is Eid and value is 1001
            hashtable.Add("Name", "James"); //Here key is Name and value is James
            hashtable.Add("Salary", 3500); //Here key is Salary and value is 3500
            hashtable.Add("Location", "Mumbai"); //Here key is Location and value is Mumbai
            hashtable.Add("EmailID", "a@a.com"); //Here key is EmailID and value is a@a.com
            //Printing the keys and their values using foreach loop
            Console.WriteLine("Printing Hashtable using Foreach Loop");
            foreach (object obj in hashtable.Keys)
            {
                Console.WriteLine(obj + " : " + hashtable[obj]);
            }
            //Or
            //foreach (DictionaryEntry de in hashtable)
            //{
            //    Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");
            //}
            Console.WriteLine("\nPrinting Hashtable using Keys");
            //I want to print the Location by using the Location key
            Console.WriteLine("Location : " + hashtable["Location"]);
            //I want to print the Email ID by using the EmailID key
            Console.WriteLine("Emaild ID : " + hashtable["EmailID"]);
            Console.ReadKey();
        }


        public void HashtableContains()
        {

            //Creating Hashtable collection with default constructor
            Hashtable hashtable = new Hashtable();
            //Adding elements to the Hash table using key value pair
            hashtable.Add("EId", 1001); //Here key is Eid and value is 1001
            hashtable.Add("Name", "James"); //Here key is Name and value is James
            hashtable.Add("Job", "Developer");
            hashtable.Add("Salary", 3500);
            hashtable.Add("Location", "Mumbai");
            hashtable.Add("Dept", "IT");
            hashtable.Add("EmailID", "a@a.com");
            //Checking the key using the Contains methid
            Console.WriteLine("Is EmailID Key Exists : " + hashtable.Contains("EmailID"));
            Console.WriteLine("Is Department Key Exists : " + hashtable.Contains("Department"));
            //Checking the key using the ContainsKey methid
            Console.WriteLine("Is EmailID Key Exists : " + hashtable.ContainsKey("EmailID"));
            Console.WriteLine("Is Department Key Exists : " + hashtable.ContainsKey("Department"));
            //Checking the value using the ContainsValue method
            Console.WriteLine("Is Mumbai value Exists : " + hashtable.ContainsValue("Mumbai"));
            Console.WriteLine("Is Technology value Exists : " + hashtable.ContainsValue("Technology"));
            Console.ReadKey();
        }


        public void RemoveData()
        {
            Hashtable employee = new Hashtable
            {
                { "EId", 1001 },
                { "Name", "James" },
                { "Salary", 3500 },
                { "Location", "Mumbai" },
                { "EmailID", "a@a.com" }
            };
            //Count Property returns the number of elements present in the collection
            Console.WriteLine($"Hashtable Total Elements: {employee.Count}");
            // Remove EId as this key exists
            employee.Remove("EId");
            Console.WriteLine($"After Removing EID Total Elements: {employee.Count}");
            //Following statement throws run-time exception: KeyNotFoundException
            //employee.Remove("City"); 
            //Check key before removing it
            if (employee.ContainsKey("City"))
            {
                employee.Remove("City");
            }
            else
            {
                Console.WriteLine("Hashtable doesnot contain City key");
            }
            //Removes all elements
            employee.Clear();
            Console.WriteLine($"After Clearing Hashtable Total Elements: {employee.Count}");
            Console.ReadKey();
        }


        public void HashtbleDictonary()
        {
            Hashtable hashtable = new Hashtable();

            hashtable[1] = "One";
            hashtable[5] = "Five";
            hashtable[30] = "Thirty";

            foreach (DictionaryEntry de in hashtable)
            {
                Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");
            }

            Console.ReadKey();
        }




        public void HashTableCasting()
        {
            //Creating Hashtable collection using collection-initializer syntax
            Hashtable employee = new Hashtable
            {
                { "EId", 1001 },
                { "Name", "James" },
                { "Salary", 3500 },
                { "Location", "Mumbai" },
                { "EmailID", "a@a.com" }
            };
            string EmployeeName = (string)employee["Name"]; //Cast to String
            int EmployeeSalary = (int)employee["Salary"];   //Cast to Int
            Console.WriteLine("Before Updating Name and Salary");
            Console.WriteLine($"Employee Name: {EmployeeName}");
            Console.WriteLine($"Employee Salary: {EmployeeSalary}");
            //Updating the Name and Salary
            employee["Name"] = "Smith"; //Update value of Name key
            employee["Salary"] = 5000; //Update value of Salary key
            Console.WriteLine("\nAfter Updating Name and Salary");
            EmployeeName = (string)employee["Name"];
            EmployeeSalary = (int)employee["Salary"];
            Console.WriteLine($"Employee Name: {EmployeeName}");
            Console.WriteLine($"Employee Salary: {EmployeeSalary}");

            Console.ReadKey();
        }


        public void HashTbleConsturctor()
        {
            //Creating Hashtable collection with default constructor
            Hashtable hashtable = new Hashtable();
            //Adding elements to the Hash table using Add method
            hashtable.Add("EId", 1001);
            hashtable.Add("Name", "James");
            hashtable.Add("Location", "Mumbai");
            //Printing All Queue Elements using For Each Loop
            Console.WriteLine("Hashtable Elements:");
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            //Copying the Hashtable to an object array
            DictionaryEntry[] myArray = new DictionaryEntry[hashtable.Count];
            hashtable.CopyTo(myArray, 0);
            Console.WriteLine("\nHashtable Copy Array Elements:");
            foreach (DictionaryEntry item in myArray)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            Object[] myObjArrayKey = new Object[hashtable.Count];
            Object[] myObjArrayValue = new Object[hashtable.Count];
            Console.WriteLine("\nCopyTo Method to Copy Keys:");
            hashtable.Keys.CopyTo(myObjArrayKey, 0);
            foreach (var key in myObjArrayKey)
            {
                Console.WriteLine($"{key} ");
            }
            Console.WriteLine("\nCopyTo Method to Copy Values:");
            hashtable.Values.CopyTo(myObjArrayValue, 0);
            foreach (var key in myObjArrayValue)
            {
                Console.WriteLine($"{key} ");
            }
        }
    }
}
