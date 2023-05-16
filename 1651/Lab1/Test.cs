using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Test
    {
        static void Main(String[] args)
        {
            Circle circle = new Circle();
            Console.WriteLine(circle);
            Console.WriteLine("Area: " + circle.Area());
            Console.WriteLine("Circumference: " + circle.Circumference());




            // Construct an author instance

            Author ahTeck = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm');

            Console.WriteLine(ahTeck); // Author's ToString()

            Book dummyBook = new Book("Java for dummy", ahTeck, 19.95, 99); // Test Book's Constructor

            Console.WriteLine(dummyBook); // Test Book's ToString()

            // Test Getters and Setters

            dummyBook.Price = 29.95;

            dummyBook.Qty = 28;

            Console.WriteLine("name is: " + dummyBook.Name);

            Console.WriteLine("price is: " + dummyBook.Price);

            Console.WriteLine("qty is: " + dummyBook.Qty);

            Console.WriteLine("Author is: " + dummyBook.Author); // Author's ToString()

            Console.WriteLine("Author's name is: " + dummyBook.Author.Name);

            Console.WriteLine("Author's email is: " + dummyBook.Author.Email);

            // Use an anonymous instance of Author to construct a Book instance

            Book anotherBook = new Book("more Java",

            new Author("Paul Tan", "paul@somewhere.com", 'm'), 29.95);

            Console.WriteLine(anotherBook); // ToString()

        }
    }

}