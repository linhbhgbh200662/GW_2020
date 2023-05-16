using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBasketDeco.GiftBasket
{
    public class HealthGiftBasket : ITetGiftBasket
    {
        public double GetCalcuateCost()
        {
            return 686;
        }

        public string GetDescription()
        {
            return "HealthGiftBasket";
        }

        
    }
}
