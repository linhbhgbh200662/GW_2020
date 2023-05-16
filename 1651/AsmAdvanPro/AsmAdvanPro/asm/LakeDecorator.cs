using System;
using System.Collections.Generic;
using System.Text;

namespace AsmAdvanPro.asm
{
    public class LakeDecorator : abLake
    {
        protected abLake _lake;
        public LakeDecorator(abLake lake)
        {
            _lake = lake;
        }
        public override double CheckLake()
        {
            return _lake.CheckLake();
        }
        public override double CaculateTotalCost()
        {
            return _lake.CaculateTotalCost();
        }
        public override double CheckKind()
        {
            return 0;
        }
}
}
