using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBasketDeco.Decorator
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
            return  _ITetGiftBasket.GetDescription() + this.GetDescriptions;
        }

        public override double GetCalcuateCost()
        {
            return _ITetGiftBasket.GetCalcuateCost() + 88;
        }
    }
}
