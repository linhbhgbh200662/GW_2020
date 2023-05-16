using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Book1
    {
        public string Name { get; }
        public Author[] Author { get; }
        public double Price { get; set; }
        public int Qty { get; set; }

        public Book1(string name, Author[] author, double price) 
        {
            Name = name;
            Author = author;
            Price = price;
            Qty = 0;
        }

        public Book1(string name, Author[] author, double price, int qty)
        {
            Name = name; 
            Author = author;
            Price = price;
            Qty = qty;
        }

        public string AuthorNames()
        {
            return Name;
        }
    }
}
