using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession07
{
	internal class Person
	{
		private string name;
		
		private string address;

		public Person(string name, string address)
		{
			this.name = name;
			this.address = address;	

		}

		//public string getName() 
		//{ 
		//	return name; 
		//}	
		//public string getAddress() 
		//{ 
		//	return address; 
		//}
		//public void setAddress(string address) 
		//{ 
		//	this.address = address;
		//}
		public override string ToString()
		{
			return name + "(" + address + ")";
		}


		/// <summary>
		public string Name
		{
			get { return name; }
		}

		public string Address
		{
			get { return address; }
			set { address = value; }
		}
		/// </summary>

	}
}
