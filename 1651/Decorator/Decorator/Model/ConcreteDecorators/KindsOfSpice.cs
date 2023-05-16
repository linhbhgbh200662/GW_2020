using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Model.ConcreteDecorators
{
    public class KindsOfSpice : TetGiftBasketDecorator
    {
        public KindsOfSpice(ITetGiftBasket tetGiftBasket) : base(tetGiftBasket)
        {
            Description = "KindsOfSpice";
        }
        public setPriceKoS(int amount)
        {
            return CacluatePrice = amount + 20.00;
        }
    }
}
