using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary.ConnectDecorator
{
	public class Cheese : PizzaDecorator
	{
		public Cheese(IPizza inner) : base(inner)
		{
			Descriptions = "Cheese";
			Cost= 13.0M;
		}
		public override String Description()
		{
			return _pizza.Description() + this.Descriptions;
		}

		public override decimal GetCost()
		{
			return _pizza.GetCost() + this.Cost;
		}
	}
}
