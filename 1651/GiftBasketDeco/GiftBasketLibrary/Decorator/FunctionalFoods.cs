using GiftBasketDeco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBasketLibrary.Decorator
{
        public class FunctionalFoods : TetGiftBasketDecorator
        {
            
            public FunctionalFoods(ITetGiftBasket tetGiftBasket) : base(tetGiftBasket)
            {
                Description = "FunctionalFoods";
            }

            public double setPriceFF(int amount)
            {
                return amount + 30.00;
            }
        }
    
}
