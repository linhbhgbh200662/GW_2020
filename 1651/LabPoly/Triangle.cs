using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPoly
{
    internal class Triangle : Shape
    {
        private int @base;   // day
        private int height;  // chieu cao

        public int Height
        {
            get { return height; }
            set { this.height = value; }
        }

        public int Base
        {
            get { return @base; } 
            set { this.@base = value; }
        }

        public Triangle()
        {
            this.Base = 1;
            this.Height = 1;
        }

        public Triangle(string color, int Height, int Base) : base( color)
        {
            this.Base = Base;
            this.Height = Height;
        }

        public override double GetArea()
        {
            return (Base * Height) / 2;
        }
        public override string ToString() 
        {
            return "Triangle[base="+Base+"height="+Height+",color="+Color+"]";
        }
    }
}
