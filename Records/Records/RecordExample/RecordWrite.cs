using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Records.RecordExample
{
    /**
     * 
     * A record in C# is a new data type that was introduced in C# 9. It is a lightweight, immutable data type that is similar to a class, but with some key differences. Records are thread-safe, and because they are immutable, you cannot change them after they are created. Records also have built-in support for equality and formatting.
     * **/
    public record Joke
    {
        public string Setup { get; init; }
        public string Punchline { get; init; }
    }


    public record DadJoke
    {
        public string Question { get; init; }
        public string Answer { get; init; }
    }
    /**
     * This record represents a person with a name and an age.It is humble because it does not have any special properties or methods.It is simply a data structure that can be used to store information about a person. */
    public record Person(string Name, int Age);


    /**
     * 
     * This record represents a book with a title, an author, and a number of pages. It is humble because it does not have any special properties or methods. It is simply a data structure that can be used to store information about a book.
     * 
     * 
     ****/



    public record Book(string Title, string Author, int Pages);


    public record Person1(string FirstName, string LastName);



    public record Person2
    {
        public required string FirstName { get; init; }
        public required string LastName { get; init; }
    };



    // You can also create record types with mutable properties and fields:
    public record Person3
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
    };

    // While records can be mutable, they are primarily intended for supporting immutable data models. The record type offers the following features:


    public record Person5(string FirstName, string LastName, string[] PhoneNumbers);

    /**
     * 
     * var phoneNumbers = new string[2];
    Person person1 = new("Nancy", "Davolio", phoneNumbers);
    Person person2 = new("Nancy", "Davolio", phoneNumbers);
    Console.WriteLine(person1 == person2); // output: True

    person1.PhoneNumbers[0] = "555-1234";
    Console.WriteLine(person1 == person2); // output: True

    Console.WriteLine(ReferenceEquals(person1, person2)); // output: False
     * 
     * **/


}
