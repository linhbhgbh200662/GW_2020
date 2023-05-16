using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary.Pizza
{
	public class TomatoPizza : IPizza
	{
		public int Size { get; set; }
		public TomatoPizza()
		{
			Size = 29;
		}
		public String Description()
		{
			return "Tomato Pizza";
		}

		public decimal GetCost()
		{
			return 200.0M;
		}

		public int GetSize()
		{
			return Size;
		}


	}
}
