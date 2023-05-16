using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_DEMO.Decorator
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

        public override decimal GetCalcuateCost()
        {
            return _ITetGiftBasket.GetCalcuateCost() + 125;
        }
    }
}
