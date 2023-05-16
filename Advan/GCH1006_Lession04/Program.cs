using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //// From the definition of a class,
            //// we can create object using the  provided cunstructor(s)
            //Ex01 one = new Ex01(); // call the default constructor
            //one.id= 101;
            //one.name = "Bùi Hương Linh";
            //one.gender = true;

            //Ex01 two= new Ex01(202, "Bùi Doãn Quân");
            //two.batch = "GEH22109";

            //Console.WriteLine("MSV: " + one.id);
            //Console.WriteLine();

            Student one = new Student(); // call the default constructor
            one.Id= 101;
            one.Name = "Bùi Hương Linh";
            one.Gender = true;

            Student two = new Student(202, "Bùi Doãn Quân");
            two.Batch = "GEH22109";

            Course java = new Course(1, "Java Programming");
            Course web = new Course(2, "Web Development");

            Console.WriteLine(one.registerACourse(java));  // true
            Console.WriteLine(two.registerACourse(java));  // true

            java.printStudentList();
            web.printStudentList();

            Student three = new Student(303, "A");
            Student four = new Student(404, "B");
            Student five = new Student(505, "C");
            Student six = new Student(606, "D");

        }
    }
}
