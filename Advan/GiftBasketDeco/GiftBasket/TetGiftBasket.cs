using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBasketDeco.GiftBasket
{
    public class TetGiftBasket : ITetGiftBasket
    {
        public double GetCalcuateCost()
        {
            return 888;
        }

        public string GetDescription()
        {
            return "TetGiftBasket";
        }
    }
}
