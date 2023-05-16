using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBasketDeco
{
    public class TetGiftBasketDecorator : ITetGiftBasket
    {
        public ITetGiftBasket _ITetGiftBasket;
        public string GetDescriptions { get; set; }
        public double CalcuateCost { get; set; }

        public TetGiftBasketDecorator(ITetGiftBasket tetgiftBasket)
        {
            _ITetGiftBasket = tetgiftBasket;
        }

        public virtual String GetDescription() 
        {
            return _ITetGiftBasket.GetDescription();
        }

        public virtual double GetCalcuateCost()
        {
            return _ITetGiftBasket.GetCalcuateCost();
        }
    }
}
