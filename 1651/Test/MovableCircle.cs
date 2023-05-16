using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class MovableCircle
    {
        private int radius;
        private MovablePoint center;

        public MovableCircle (int radius, int x, int y, int xSpeed, int ySpeed) 
        {
            this.radius = radius;
        }

        public int Radius
        {
            get { return radius; }
            set { this.radius = value; }
        }

        public void MoveUp()
        {
            y++;
        }
        public void MoveDown()
        {
            y--;
        }
        public void MoveLeft()
        {
            x--;
        }
        public void MoveRight()
        {
            x++;
        }
        public override string ToString()
        {
            return "MovablePoint with radius= " + radius + " and y = " + y + " and xSpeed = " + xSpeed + " and ySpeed = " + ySpeed;
        }
    }
}
