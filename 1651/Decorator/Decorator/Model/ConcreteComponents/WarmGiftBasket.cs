using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Model.ConcreteComponents
{
    public class WarmGiftBasket : ITetGiftbasket
    {
        public WarmGiftBasket()
        {
            Description = "Warm Gift Basket";
        }

        public override string getDescription()
        {
            return Description;
        }

        public override CacluateCost()
        {
            return CacluateCost = setPriceW + setPriceKoS;
        }
    }
}