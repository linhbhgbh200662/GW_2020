using GiftBasketDeco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBasketLibrary.Decorator
{
    public class Snacks : TetGiftBasketDecorator
    {
         
        public Snacks(ITetGiftBasket tetGiftBasket) : base(tetGiftBasket)
        {
            Description = "Snacks";
        }
        public double setPriceS(int amount)
        {
            return amount + 9.25;
        }
    }
}
