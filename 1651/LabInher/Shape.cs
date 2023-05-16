using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInher
{
    internal class Shape
    {
        public string Color;
        public bool Filled;
        public Shape() 
        {
            this.Color = "red";
            this.Filled = true;
        }

        public Shape(string color, bool filled)
        {
            this.Color = color;
            this.Filled = filled;
        }

        public override string ToString()
        {
            return " A Shape with [color = " + Color + " , " + "filler =" + Filled + "]";
        }
    }
}
