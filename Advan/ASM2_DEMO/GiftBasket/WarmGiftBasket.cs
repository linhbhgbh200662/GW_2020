using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_DEMO.GiftBasket
{
    public class WarmGiftBasket : ITetGiftBasket
    {
        public decimal GetCalcuateCost()
        {
            return 555;
        }

        public string GetDescription()
        {
            return "WarmGiftBasket";
        }
    }
}
