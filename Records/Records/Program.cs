using Records.RecordExample;

namespace Records
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var joke = new Joke
            {
                Setup = "What do you call a fish with no eyes?",
                Punchline = "Fish!"
            };

            Console.WriteLine(joke);


            var jokes = new DadJoke
            {
                Question = "Why did the scarecrow win an award?",
                Answer = "Because he was outstanding in his field!"
            };

            Console.WriteLine(jokes);


            var person = new Person("John Doe", 30);

            Console.WriteLine(person.Name); // Prints "John Doe"
            Console.WriteLine(person.Age); // Prints 30


            var book = new Book("The Hitchhiker's Guide to the Galaxy", "Douglas Adams", 256);

            Console.WriteLine(book.Title); // Prints "The Hitchhiker's Guide to the Galaxy"
            Console.WriteLine(book.Author); // Prints "Douglas Adams"
            Console.WriteLine(book.Pages); // Prints 256

        }
    }
}