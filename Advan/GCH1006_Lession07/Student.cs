using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession07
{
	internal class Student : Person
	{
		private int numCourses;
		//private string[] courses;
		//private int[] grades;
		private const int MAX = 30;

		private List<string> courses;
		private List<int> grades;
		// dùng mảng: private string[] courses;
		// private List<Course> courses;

		public Student(string name, string address) : base(name, address)
		{
			
			numCourses = 0;
			// courses = new string[MAX] // sd mảng
			courses= new List<string>();
			grades = new List<int>();
		}

		public override string ToString()
		{
			return "Student: " + base.ToString();
		}

		public void addCourseGrade(string course, int grade)
		{
			if (numCourses< MAX)
			{
				courses.Add(course);
				grades.Add(grade);
				//numCourses++;
				numCourses = courses.Count;
			}
			else
			{
				Console.WriteLine("A student can study no more than {0} course(s)", MAX);
			}
		}

		public void printGrade()
		{
			for (int i = 0; i < numCourses; i++)
			{
				Console.WriteLine("Course: {0, -20} | Grade: {1, -4}", courses[i], grades[i]);
			}
		}

		public double getAverageGrade()
		{
			//int sum = 0;
			//foreach( int each in grades )
			//{
			//	sum += each;
			//}
			//return sum * 1.0 / numCourses;

			return grades.Average();
		}

		
		

	}
}
