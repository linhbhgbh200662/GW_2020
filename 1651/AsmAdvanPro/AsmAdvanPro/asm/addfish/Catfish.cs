﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AsmAdvanPro.asm.addfish
{
    public class Catfish : LakeDecorator
    {
        public int kind;
        public float food;
        public float price;
        public int space;
        public Catfish(abLake lake) : base(lake)
        {
            this.kind = 1;
            this.food = 100;
            this.price = 40000;
            this.space = 10;

        }
        public override double CheckLake()
        { 
            return base.CheckLake() - this.space;
        }
        public override double CaculateTotalCost()
        {
        return base.CaculateTotalCost() + (this.food) + this.price;
        }
        public override double CheckKind()
        {
            return 2;
        }
        public override string ToString()
        {
            return " Price of food:" + this.food + "vnd:  space to live" + this.space + "m3 price " + this.price + "vnd";
        }

    }
}
