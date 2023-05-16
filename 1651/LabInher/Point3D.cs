using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInher
{
    internal class Point3D : Point2D
    {
        public int Z;

        public Point3D() : base()
        {
            this.Z= 0;
        }
        
        public Point3D(int x, int y, int z) : base(x,y)
        {
            this.Z = z;
        }

        public override string ToString()
        {
            return "(" + X + "," + Y + "," + Z + ")";
        }

    }
}
