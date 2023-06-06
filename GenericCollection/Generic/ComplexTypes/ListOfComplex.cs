using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.ComplexTypes
{
    public class ListOfComplex
    {

        public void ListCollectionSortReverse()
        {
            List<int> numbersList = new List<int> { 1, 8, 7, 5, 2 };
            Console.WriteLine("Numbers Before Sorting");
            foreach (int i in numbersList)
            {
                Console.Write($"{i} ");
            }

            // The Sort() of List Collection class will sort the data in ascending order 
            numbersList.Sort();
            Console.WriteLine("\n\nNumbers After Sorting");
            foreach (int i in numbersList)
            {
                Console.Write($"{i} ");
            }

            // If you want to retrieve data in descending order then use the Reverse() method
            numbersList.Reverse();
            Console.WriteLine("\n\nNumbers in Descending order");
            foreach (int i in numbersList)
            {
                Console.Write($"{i} ");
            }

            //Another Example of Sorting String
            List<string> names = new List<string>() { "Pranaya", "Anurag", "Sambit", "Hina", "Rakesh" };
            Console.WriteLine("\n\nNames Before Sorting");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.Sort();
            Console.WriteLine("\nNames After Sorting");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.Reverse();
            Console.WriteLine("\nNames in Descending Order");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }


        public void ListCollection()
        {

            //Creating a list of type Employee
            List<Employee> listEmployees = new List<Employee>
            {
                new Employee() { ID = 101, Name = "Pranaya", Gender = "Male", Salary = 5000 },
                new Employee() { ID = 102, Name = "Priyanka", Gender = "Female", Salary = 7000 },
                new Employee() { ID = 103, Name = "Anurag", Gender = "Male", Salary = 5500 },
                new Employee() { ID = 104, Name = "Sambit", Gender = "Male", Salary = 6500 },
                new Employee() { ID = 105, Name = "Hina", Gender = "Female", Salary = 6500 }
            };
            Console.WriteLine("Employees Before Sorting");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1},  Gender = {2}, Salary = {3}",
                    employee.ID, employee.Name, employee.Gender, employee.Salary);
            }
            listEmployees.Sort();
            Console.WriteLine("\nEmployees After Sorting");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1},  Gender = {2}, Salary = {3}",
                    employee.ID, employee.Name, employee.Gender, employee.Salary);
            }
            Console.ReadKey();
        }

    }


    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }



}
