using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPoly
{
    class Test2
    {
        public static void Main(String[] args)
        {

            Shape s1 = new Rectangle("red", 4, 5); // Upcast

            Console.WriteLine(s1); // Run Rectangle's toString()

            Console.WriteLine("Area is " + s1.GetArea()); // Run Rectangle's getArea()

            Shape s2 = new Triangle("blue", 4, 5); // Upcast

            Console.WriteLine(s2); // Run Triangle's toString()

            Console.WriteLine("Area is " + s2.GetArea()); // Run Triangle's getArea()


        }
    }
}
