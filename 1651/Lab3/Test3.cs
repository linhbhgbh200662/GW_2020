using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab3
{
    public class Test3
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(4, 6,"red");
            Console.WriteLine(t1.ToString());
            Console.WriteLine("Area: " + t1.Getarea());
            Rectangle r1 = new Rectangle(6, 7, "green");
            Console.WriteLine(r1.ToString());
            Console.WriteLine("Area: " + r1.Getarea());
            MovablePoint m = new MovablePoint(1, 2);
            Console.WriteLine(m.ToString());
            m.MoveUP();
            Console.WriteLine(m.ToString());
            m.MoveDOWN();
            Console.WriteLine(m.ToString());
            m.MoveLEFT();
            Console.WriteLine(m.ToString());
            m.MoveRIGHT();
            Console.WriteLine(m.ToString());

            Fish d = new Fish();
            Console.WriteLine(d.ToString());
            d.Eat();
            d.Walk();
            d.Play();
            Cat c = new Cat("Fluffy");
            c.Eat();
            c.Walk();
            c.Play();
            Animal a = new Fish("FFF");
            a.Eat();
            a.Walk();
            Animal e = new Spider();
            Console.WriteLine(d.ToString());
            e.Eat();
            e.Walk();
            Pet p = new Cat();
            Console.WriteLine(p.ToString());
            Cat diu = new Cat("DiuDiu");
            diu.Eat();
            diu.Walk();
            diu.Play();
        }
    }
}