using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Model.ConcreteDecorators
{
    public class FunctionalFoods : TetGiftBasketDecorator
    {
        public FunctionalFoods(ITetGiftBasket tetGiftBasket) : base(tetGiftBasket)
        {
            Description = "FunctionalFoods";
        }

        public setPriceFF(int amount)
        {
            return CacluatePrice = amount + 30.00;
        }
    }
}
