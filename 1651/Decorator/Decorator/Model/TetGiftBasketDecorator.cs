using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Model
{
    public class TetGiftBasketDecorator : ITetGiftBasket
    {
        protected ITetGiftBasket _ITetGiftBasket;

        public TetGiftBasketDecorator(ITetGiftBasket ITetgiftBasket)
        {
            _ITetGiftBasket = ITetGiftBasket;
        }

        public override string getDescription()
        {
            return _ITetGiftBasket.Description;
        }

        public override double CalculateCost()
        {
            return _ITetGiftBasket.CalculateCost();
        }
    }
}
