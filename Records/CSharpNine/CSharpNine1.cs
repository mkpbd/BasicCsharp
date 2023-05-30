namespace CSharpNine
{
    public class Person
    {
        // init
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public Person(string firstName, string lastName) => (FirstName, LastName) = (firstName, lastName);


    }


    // Records 

    // Declaration
    public record Person2(string FirstName, string LastName);


    public class GetResult
    {
        public void MainResult(string[] args)
        {
            var person1 = new Person("Danny", "Skoog"); // OK
            var person2 = new Person("Danny", "Skoog") { FirstName = "Mike" }; // OK
                                                                               // person1.FirstName = "Mike"; //  Get Errors

            /// Equality
            var person3 = new Person2("Danny", "Skoog");
            var person4 = new Person2("Danny", "Skoog");
            Console.WriteLine(person1 == person2); // Outputs "True"

            // ToString
            Console.WriteLine(person3.ToString()); // Outputs "Person { FirstName = Danny, LastName = Skoog }"

            // Deconstruction

            var (firstName, lastName) = person3;


            // Immutability
            var person5 = new Person("Danny", "Skoog"); // OK
            var person6 = new Person("Danny", "Skoog") { FirstName = "Mike", LastName = "Johnson" }; // OK
            var person7 = person3 with { FirstName = "Mike" }; // OK
                                                               //   person8.FirstName = "Mike"; // NOT OK

        }



        public void RowString()
        {
            /**
             * 
             * We already know that the ordinary strings that C# has, tend to be quite messy since they need quotation marks (''), newlines (\ n) and backslashes (). What C# offers before this little problem is the use of special characters.
             * For example, we can prefix a string with @ and have free rein to add all these details without any problem
             * 
             * ***/
            string path = "c:\\path\\backslashes";
            string path1 = @"c:\pathh\backslashes";


            /***
             * 
             * What the raw string literal string allows is to create new paths to avoid escaping problems. Using the delimiter of a series of quotes followed by a line break to start, and a line break followed by the same number of quotes to close.
             * 
             * ***/

            string xml = """
                  <part number="2021">
                    <name>year</name>
                    <description>this is the actual year
                     <ref part="2020">year</ref> actual year.
                    </description>
                  </part>
          """;




        }


    }

    public class DataSlice
    {
        public string DataLabel { get; }
        public float DataValue { get; }

        public DataSlice(string dataLabel, float dataValue)
        {
            DataLabel = dataLabel;
            DataValue = dataValue;
        }
    }



}