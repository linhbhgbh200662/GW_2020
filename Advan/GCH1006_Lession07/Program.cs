using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession07
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person p1 = new Person("Bùi Hương Linh", "Hà Nội");
			Console.WriteLine(p1.ToString());
			p1.Address = "HCM City";
			Console.WriteLine(p1.ToString());



			Student st1 = new Student("Thiên", "Ha Noi");
			Console.WriteLine(st1.ToString());
			st1.Address = "Đồng Nai";
			//st1.Name= "Test"; //lỗi
			st1.addCourseGrade("Pro", 88);
			st1.addCourseGrade("Java", 77);
			//st1.printGrades();
			Console.WriteLine(st1.ToString());

			st1.addCourseGrade("Java", 4);
			st1.addCourseGrade("Web development", 8);
			st1.addCourseGrade("Database", 6);

			st1.printGrade();
			Console.WriteLine("Average grade is: " + st1.getAverageGrade());

			Console.WriteLine("------------------");
			Teacher t1 = new Teacher("Đỗ Hồng Quân", "Hà Nội");
			Console.WriteLine(t1.addCourse("Java")); //true
			Console.WriteLine(t1.addCourse("Java")); //false
			Console.WriteLine(t1.addCourse("Database")); //true
			Console.WriteLine(t1.addCourse("Web development")); //true
			Console.WriteLine(t1.addCourse("Security")); //true

			Console.WriteLine("------------------");
			Console.WriteLine(t1.removeCourse("Java")); //true
			Console.WriteLine(t1.removeCourse("Java")); //false
			Console.WriteLine(t1.removeCourse("Database")); //true

		}
	}
}
