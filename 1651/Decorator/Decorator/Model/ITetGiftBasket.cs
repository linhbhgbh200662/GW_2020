using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Model
{
    public interface ITetGiftBasket
    {
        public string Description { get; set; }

        public override string GetDescription();

        public override double CalculateCost();
    }
}
