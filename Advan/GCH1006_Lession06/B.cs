using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession06
{
	internal class B : A
	{
		public B(int id, string name) : base(id, name) 
		{
			//base.Id = ...
			salary = 10000;
		}

		public sealed override void methodA() 
		{ 
			Console.WriteLine("Redefined in class B");
			Console.Write("Original method said: ");
			base.methodA();
		}
		public void methodA(string name, double price)
		{
			Console.WriteLine(name + " calls Method of class B at the price " + price);
		}
	}
}
