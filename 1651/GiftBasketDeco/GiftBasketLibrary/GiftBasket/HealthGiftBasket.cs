using GiftBasketDeco;
using GiftBasketLibrary.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBasketLibrary.GiftBasket
{
    public class HealthGiftBasket : ITetGiftBasket
    {
        public HealthGiftBasket()
        {
            Description = "Health Gift Basket";
        }

        List<FunctionalFoods> ffoods = new List<FunctionalFoods>(); 
        List<Snacks> snacks = new List<Snacks>();

        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return  555.000 ;
        }
    }
}
