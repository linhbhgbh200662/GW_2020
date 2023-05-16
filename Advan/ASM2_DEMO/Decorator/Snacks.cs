using ASM2_DEMO.GiftBasket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_DEMO.Decorator
{
    public class Snacks : TetGiftBasketDecorator
    {
        public Snacks(ITetGiftBasket tetGiftBasket) : base(tetGiftBasket)
        {
            GetDescriptions = "Snacks";
        }

        public override String GetDescription()
        {
            return _ITetGiftBasket.GetDescription() + this.GetDescriptions;
        }

        public override decimal GetCalcuateCost()
        {
            return _ITetGiftBasket.GetCalcuateCost() + 8;
        }

    }
}
