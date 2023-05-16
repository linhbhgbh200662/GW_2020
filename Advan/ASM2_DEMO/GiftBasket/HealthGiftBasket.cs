using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_DEMO.GiftBasket
{
    public class HealthGiftBasket : ITetGiftBasket
    {
        public decimal GetCalcuateCost()
        {
            return 686;
        }

        public string GetDescription()
        {
            return "HealthGiftBasket";
        }


    }
}
