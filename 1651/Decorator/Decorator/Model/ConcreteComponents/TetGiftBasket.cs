using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Model.ConcreteComponents
{
    public class TetGiftBasket : ITetGiftbasket
    {
        public TetGiftBasket() 
        {
            Description = "Tet Gift Basket";
        }

        public override string getDescription()
        {
            return Description;
        }

        public override CacluateCost()
        {
            return CacluateCost = setPriceS + setPriceW;
        }
    }
}