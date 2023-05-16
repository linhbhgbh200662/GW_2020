using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInher
{
    internal class Square : Rectangle
    {
        public double Side { get; set; }
        public override double Length
        {
            get { return Side; }
            set { Side = value; }
            
        }

        public override double Width
        {
            get { return Side; }
            set { Side= value; }
            
        }
        public Square(double side): base(side,side)
        {
            Side = side;
            
        }

        public override string ToString()
        {
            return "A Square with side=" + Side + ", which is a subclass of " + base.ToString();
        }
    }
}
