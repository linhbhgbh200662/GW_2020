using ASM2_DEMO.GiftBasket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_DEMO.Decorator
{
    public class FunctionalFoods : TetGiftBasketDecorator
    {
        public FunctionalFoods(ITetGiftBasket tetgiftBasket) : base(tetgiftBasket)
        {
            GetDescriptions = "FunctionalFoods";
            //CalcuateCost = 8;
        }

        public override string GetDescription()
        {
            return _ITetGiftBasket.GetDescription();
        }

        public override decimal GetCalcuateCost()
        {
            return _ITetGiftBasket.GetCalcuateCost() + 88;
        }
    }
}
