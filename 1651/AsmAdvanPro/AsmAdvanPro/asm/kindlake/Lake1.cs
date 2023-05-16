using System;
using System.Collections.Generic;
using System.Text;

namespace AsmAdvanPro.asm.kindlake
{
    class Lake1:abLake
    {
        public double volume;
        public string water;
        public double depth;
        public Lake1()
        {
            this.volume = 10;
            this.water = "salt water";
            this.depth = 3;

        }
        public override double CaculateTotalCost()
        {
            return  + volume * 1000;
        }
        public override double CheckLake()
        {
            return this.volume;
        }
        public override double CheckKind()
        {
            return 0;
        }
        public override string ToString()
        {
            return "Lake have volume: " + this.volume+"m3  kind of water: " + this.water + " with depth " + this.depth+"m";
        }
    }
}
