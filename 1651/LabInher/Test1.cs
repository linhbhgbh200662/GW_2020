using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInher
{
    internal class Test1
    {
        public static void Main(string[] args)
        {
            /* Test Point2D*/
            // Test constructors and toString()
            Point2D p2a = new Point2D(1, 2);
            Console.WriteLine(p2a);   // toString()
            Point2D p2b = new Point2D();
            Console.WriteLine(p2b);
            // Test Setters and Getters
            p2a.X = 3; // Test setters
            p2a.Y = 4;
            Console.WriteLine(p2a);   // toString()
            Console.WriteLine("x is: " + p2a.X);
            Console.WriteLine("x is: " + p2a.Y);

            /* Test Point3D*/
            // Test constructors and toString()
            Point3D p3a = new Point3D(11, 12, 13);
            Console.WriteLine(p3a);  // toString()
            Point2D p3b = new Point3D(); // default constructor
            Console.WriteLine(p3b);

            // Test Setters and Getters
            p3a.X = 21; // in baseclass
            p3a.Y = 22; // in baseclass
            p3a.Z = 23; // in this class
            Console.WriteLine(p3a);                // toString()
            Console.WriteLine("x is: " + p3a.X);   // in baseclass
            Console.WriteLine("y is: " + p3a.Y);   // in baseclass
            Console.WriteLine("z is: " + p3a.Z);   // in this class

            Square s = new Square(2);
            Console.WriteLine(s.GetArea());        //4
            Console.WriteLine(s.GetPerimeter());   //8

            s.Side = 3;
            Console.WriteLine(s.GetArea());        //9
            Console.WriteLine(s.GetPerimeter());   //12

            s.Length= 4; 
            Console.WriteLine(s.GetArea());        //16
            Console.WriteLine(s.GetPerimeter());   // 16

            s.Width= 5;
            Console.WriteLine(s.GetArea());        //25
            Console.WriteLine(s.GetPerimeter());   //20

            Console.Read();
        }
    }
}
