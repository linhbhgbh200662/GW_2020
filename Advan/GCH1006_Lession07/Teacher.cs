using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession07
{
	internal class Teacher : Person
	{
		private int numCourses;
		private List<string> courses;
		private const int MAX= 5;

		public Teacher(string name, string address) : base(name, address)
		{
			numCourses= 0;
			courses = new List<string>();
		}

		public override string ToString()
		{
			return "Teacher: " + base.ToString();
		}

		public bool addCourse(string name)
		{
			if(numCourses< MAX && !courses.Contains(name))
			{
				courses.Add(name);
				numCourses = courses.Count;
				return true;
			}	
			else
			    return false;
		}

		public bool removeCourse(string name)
		{
			bool flag = courses.Remove(Name);
			//if(flag)
			//{
			//	numCourses--;
			//}

			numCourses = courses.Count;
			return flag;
		}

	}
}
