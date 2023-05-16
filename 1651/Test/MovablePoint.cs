using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class MovablePoint
    {
        int x;
        int y;
        int xSpeed;
        int ySpeed;

        public MovablePoint(int x, int y, int xSpeed, int ySpeed)
        {
            this.x = x;
            this.y = y;
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }
        public void MoveUp()
        {
            this.y += this.ySpeed;
        }
        public void MoveDown()
        {
            this.y -= this.ySpeed;
        }
        public void MoveLeft()
        {
            this,;
        }
        public void MoveRight()
        {
            x++;
        }
        public override string ToString()
        {
            return "MovablePoint with x = " + x + " and y = " + y + " and xSpeed = " + xSpeed + " and ySpeed = " + ySpeed ;
        }
    }
}
