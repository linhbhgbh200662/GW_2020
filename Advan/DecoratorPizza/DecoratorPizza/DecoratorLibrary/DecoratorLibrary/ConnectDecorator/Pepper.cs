using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary.ConnectDecorator
{
	public class Pepper : PizzaDecorator
	{
		public Pepper(IPizza inner) : base(inner)
		{
			Descriptions = "Pepper";
			Cost = 10.0M;
		}
		public override String Description()
		{
			return _pizza.Description();
		}

		public override decimal GetCost()
		{
			return _pizza.GetCost() + this.Cost;
		}
	}
}
