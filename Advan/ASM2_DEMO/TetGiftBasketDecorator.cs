using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_DEMO
{
    public class TetGiftBasketDecorator
    {
        public ITetGiftBasket _ITetGiftBasket;
        public string GetDescriptions { get; set; }
        public decimal CalcuateCost { get; set; }

        public TetGiftBasketDecorator(ITetGiftBasket tetgiftBasket)
        {
            _ITetGiftBasket = tetgiftBasket;
        }

        public virtual String GetDescription()
        {
            return _ITetGiftBasket.GetDescription();
        }

        public virtual decimal GetCalcuateCost()
        {
            return _ITetGiftBasket.GetCalcuateCost();
        }

    }
}
