using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Model.ConcreteDecorators
{
    public class Snacks : TetGiftBasketDecorator
    {
        public Snacks(ITetGiftBasket tetGiftBasket) : base(tetGiftBasket)
        {
            Description = "Snacks";
        }
        public setPriceS(int amount)
        {
            return CacluatePrice = amount + 9.25;
        }
    }
}
