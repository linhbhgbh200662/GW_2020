using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary.Pizza
{
	public class BeefyPizza : IPizza
	{
		public int Size { get; set; }

		public BeefyPizza()
		{
			Size = 25;
		}
		public String Description()
		{
			return "Beefy Pizza";
		}

		public decimal GetCost()
		{
			return 150.0M;
		}
		public int GetSize()
		{
			return Size;
		}

	}
}
