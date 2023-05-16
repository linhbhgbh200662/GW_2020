using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPoly
{
    internal class Shape
    {
        private string color;

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Shape() 
        {
            this.Color = "red";
        }

        public Shape(string color)
        {
            Color = color;
        }

        public virtual double GetArea()
        {
            return 0.0;
        }

        public override string ToString()
        {
            return "Shape[color=" + color + "]";
        }
    }
}
