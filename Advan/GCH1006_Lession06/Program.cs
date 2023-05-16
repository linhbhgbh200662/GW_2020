using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession06
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			B one = new B();
			one.methodA();  // Redefined in class B <calls the methodA() overrided in B>
			one.methodA("Quan"); // Quan calls Method of class A
			one.methodA("Quan", 50.5);
			Console.WriteLine("--------------------");

		}
	}
}
