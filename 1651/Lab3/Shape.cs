using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Lab3
{
    abstract class Shape
    {
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }

        }
        public Shape(string color)
        {
            this.color = color;
        }
        public abstract double Getarea();
        public virtual string ToString()
        {
            return "Shape with color of " + color;
        }
        
    }
}