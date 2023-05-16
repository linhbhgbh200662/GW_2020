using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBasketDeco
{
    public class TetGiftBasketDecorator : ITetGiftBasket
    {
        public ITetGiftBasket _ITetGiftBasket;

        public TetGiftBasketDecorator(ITetGiftBasket iTetgiftBasket)
        {
            _ITetGiftBasket = iTetgiftBasket;
        }

        public override string GetDescription()
        {
            return _ITetGiftBasket.Description;
        }

        public override double CalculateCost()
        {
            return _ITetGiftBasket.CalculateCost();
        }

       
    }
}
