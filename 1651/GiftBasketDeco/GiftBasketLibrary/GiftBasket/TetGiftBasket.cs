using GiftBasketDeco;
using GiftBasketLibrary.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBasketLibrary.GiftBasket
{
    public class TetGiftBasket : ITetGiftBasket
    {
        List<Snacks> snacks = new List<Snacks>();
        List<Wine> wine = new List<Wine>();
        public TetGiftBasket()
        {
            Description = "Tet Gift Basket";
        }
        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return ;
        }
    }
}
