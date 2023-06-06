using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.ComplexTypes
{
    public class Employees : IComparable<Employees>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public int CompareTo(Employees obj)
        {
            if (Salary > obj.Salary)
            {
                return 1;
            }
            else if (Salary < obj.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

      
    }
}


/**
 * 
 * 
 * 
 * //Creating a list of type Employee
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
 * 
 * 
 * 
 * **/