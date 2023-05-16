using System;
using System.Collections.Generic;
using System.Text;

namespace AsmAdvanPro.asm.kindlake
{
    class Lake2: abLake
    {
        public double volume;
        public string water;
        public double depth;
        public Lake2()
        {
            this.volume = 2000;
            this.water = "fresh water";
            this.depth = 3;
        }
        public override double CheckLake()
        {
            return volume;
        }
        public override double CaculateTotalCost()
        {
            return this.volume * 1000;
        }
        public override double CheckKind()
        {
            return 0;
        }
        public override string ToString()
        {
            return "Lake have volume: " + this.volume + "m3  kind of water: " + this.water + " with depth " + this.depth + "m";
        }
        

    }
}
