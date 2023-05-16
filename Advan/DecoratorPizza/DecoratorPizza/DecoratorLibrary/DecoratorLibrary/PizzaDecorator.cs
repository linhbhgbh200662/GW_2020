using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary
{
	public abstract class PizzaDecorator : IPizza
	{
		public IPizza _pizza;
		public string Descriptions { get; set; }
		public decimal Cost { get; set; }
		protected PizzaDecorator(IPizza inner)
		{
			_pizza = inner;
		}
		public virtual String Description()
		{
			return _pizza.Description();
		}

		public virtual decimal GetCost()
		{
			return _pizza.GetCost();
		}

	}
}
