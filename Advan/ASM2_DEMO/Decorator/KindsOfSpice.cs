using ASM2_DEMO.GiftBasket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_DEMO.Decorator
{
    public class KindsOfSpice : TetGiftBasketDecorator
    {
        public KindsOfSpice(ITetGiftBasket tetGiftBasket) : base(tetGiftBasket)
    {
        GetDescriptions = "KindsOfSpice";
    }

    public override string GetDescription()
    {
        return _ITetGiftBasket.GetDescription() + this.GetDescriptions;
    }

    public override decimal GetCalcuateCost()
    {
        return _ITetGiftBasket.GetCalcuateCost() + 45;
    }
}
}
