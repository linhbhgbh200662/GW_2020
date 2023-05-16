using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession05
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			//Student st1 = new Student(101, "Quân", "Male", "Đan Phượng");
			//Student st2 = new Student(202, "Linh", "Female", "Đan Phượng");

			//Console.WriteLine(st1);
			//Console.WriteLine(st2);

			int N = 5;
			List<Student> student = new List<Student>(N);
				student.Add(new Student(101, "Quân", "Male", "Đan Phượng"));
			    student.Add(new Student(102, "Linh", "Female", "Đan Phượng"));
		        student.Add(new Student(103, "Ngọc", "Female", "Quảng Ninh"));
		        student.Add(new Student(104, "Hương", "Female", "Đan Phượng"));
		        student.Add(new Student(105, "My", "Female", "Đan Phượng"));
			foreach (Student st in student)
			{
				Console.WriteLine(" " + st);
			}

			// 3.
			int count_male = 0;
			foreach(Student each in student)
			{
				if (each.Gender)
					count_male++;
			}
			Console.WriteLine("Male percentage is: " + (count_male * 1.0 / student.Count) * 100 + "%");
		}
	}
}
