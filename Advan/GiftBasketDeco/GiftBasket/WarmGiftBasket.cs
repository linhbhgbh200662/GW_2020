using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBasketDeco.GiftBasket
{
    public class WarmGiftBasket : ITetGiftBasket
    {
        public double GetCalcuateCost()
        {
            return 555;
        }

        public string GetDescription()
        {
            return "WarmGiftBasket";
        }
    }
}
