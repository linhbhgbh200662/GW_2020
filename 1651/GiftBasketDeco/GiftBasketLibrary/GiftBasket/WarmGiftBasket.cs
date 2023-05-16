using GiftBasketDeco;
using GiftBasketLibrary.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GiftBasketLibrary.GiftBasket
{
    public class WarmGiftBasket : ITetGiftBasket
    {
        List<Snacks> snacks = new List<Snacks>();
        List<KindsOfSpice> KoS = new List<KindsOfSpice>();
        public WarmGiftBasket()
        {
            Description = "Warm Gift Basket";
        }
        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return snacks + KoS;
        }
        public override string ToString()
        {
            return "Snacks" + snacks + " " + "KindsOfSpice" + KoS;
        }
    }
}
