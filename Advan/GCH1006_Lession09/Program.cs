using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession09
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Admin one = Admin.Instance;   // new Admin():: hàm khởi tạo
			Admin two = Admin.Instance;

			if(one == two)
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}

			Console.WriteLine(two.Id);
			//Admin.destroy();
			Console.WriteLine(one.Id);
			one.Name = "Do Hong Quan";
			Console.WriteLine(two.Name);
			if(one == null )
			{
				Console.WriteLine("Null");
			}
			else
			{
				Console.WriteLine("Not null");
			}	
		}
	}
}
