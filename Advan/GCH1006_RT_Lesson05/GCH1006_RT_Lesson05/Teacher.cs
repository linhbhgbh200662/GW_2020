using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_RT_Lesson05
{
	// pro tab tab
	//profull tab tab 
	public class Teacher
	{
		private int id;

		public int Id
		{
			get { return id; }
		}

		private string name;
		public string Name
		{ 
			get { return name; }
			set { name = value; }
		}

		public string Address { get;  set; }
		private bool gender;

		public bool Gender
		{
			set { gender = value; }
		}

		private string _email;
		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}
		public void print()
		{
			Console.WriteLine(id);
		}
	}
}
