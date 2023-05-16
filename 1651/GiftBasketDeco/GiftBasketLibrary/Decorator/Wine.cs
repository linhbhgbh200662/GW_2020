using GiftBasketDeco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBasketLibrary.Decorator
{
    public class Wine : TetGiftBasketDecorator
    {
        
        public Wine(ITetGiftBasket tetGiftBasket) : base(tetGiftBasket)
        {
            Description = "Wine";
        }
        public double setPriceW(int amount)
        {
            return amount + 10.00;
        }
    }
}
