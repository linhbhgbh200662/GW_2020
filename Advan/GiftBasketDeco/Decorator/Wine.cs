using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBasketDeco.Decorator
{
    public class Wine : TetGiftBasketDecorator
    {
        public Wine(ITetGiftBasket tetGiftBasket) : base(tetGiftBasket)
        {
            GetDescriptions = "Wine";
        }

        public override String GetDescription()
        {
            return _ITetGiftBasket.GetDescription() + this.GetDescriptions;
        }

        public override double GetCalcuateCost()
        {
            return _ITetGiftBasket.GetCalcuateCost() + 125;
        }
    }
}
