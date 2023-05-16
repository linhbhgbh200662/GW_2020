using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary.Pizza
{
	public class CheckenPizza : IPizza
	{
		public int Size { get; set; }

		public CheckenPizza()
		{
			Size = 20;
		}

		public String Description()
		{
			return "Checken Pizza";
		}

		public decimal GetCost()
		{
			return 100.0M;
		}

		public int GetSize()
		{
			return Size;
		}





	}
}
