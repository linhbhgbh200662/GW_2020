using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary.ConnectDecorator
{
	public class Ham : PizzaDecorator
	{
		public Ham(IPizza inner) : base(inner)
		{
			Descriptions = "Ham";
			Cost= 12.0M;
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
