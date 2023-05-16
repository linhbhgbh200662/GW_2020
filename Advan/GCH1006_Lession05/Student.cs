using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession05
{
	// 1. Define a class: Student (Id, Name, Gender, Address)
	// 2. Create a list of N students
	// 3. Calculate the male percentage in the list created in task 2
	// 4. Write a function to find those students whose name contains a given key
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Gender { get; set; }
		public string Address { get; set; }

		public Student(int id, string name, string gender, string addrress)
        {
			this.Id = id;
			this.Name = name;
			this.Gender = gender;
			this.Address = addrress;
		}

		public override string ToString()
		{
			return "Id:" + Id +" " + "Name: " + Name + " " + "Gender: " + Gender + " " + "Adress: " + Address;
		}
	}
}
