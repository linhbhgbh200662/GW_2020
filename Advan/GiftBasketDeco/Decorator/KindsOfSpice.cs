using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBasketDeco.Decorator
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

        public override double GetCalcuateCost()
        {
            return _ITetGiftBasket.GetCalcuateCost() + 45;
        }
    }
}
