using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_DEMO.GiftBasket
{
    public class TetGiftBasket : ITetGiftBasket
    {
        public decimal GetCalcuateCost()
        {
            return 888;
        }

        public string GetDescription()
        {
            return "TetGiftBasket";
        }
    }
}
