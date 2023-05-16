using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession06
{
	internal class A // internal sealed class A: thằng B khum kế đc A( A khum cho phéo kế thừa)
	{
		public virtual void methodA()
		{
			Console.WriteLine("Method of class A");
		}


		//public int methodA()
		//{
		//	Console.WriteLine("Method of class A");
		//}
		public void methodA(string name)
		{
			Console.WriteLine(name + " calls Method of class A");
		}
	}
}
