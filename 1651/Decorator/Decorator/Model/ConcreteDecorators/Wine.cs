using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Model.ConcreteDecorators
{
    public class Wine : TetGiftBasketDecorator
    {
        public Wine(ITetGiftBasket tetGiftBasket) : base(tetGiftBasket) 
        {
            Description = "Wine";
        }
        public setPriceW(int amount)
        {
            return CacluatePrice = amount + 10.00;
        }
    }
}
