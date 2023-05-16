using GiftBasketDeco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBasketLibrary.Decorator
{
    public class KindsOfSpice : TetGiftBasketDecorator
    {
        
        public KindsOfSpice(ITetGiftBasket tetGiftBasket) : base(tetGiftBasket)
        {
            Description = "KindsOfSpice";
        }
        public double setPriceKoS(int amount)
        {
            return  amount + 20.00;
        }
    }
}
