using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class DemoTest
    {
        public static void Main(String[] args)
        {

            Temperature ftemp = new Temperature(212);
            double f = 1;
            do
            {
                Console.WriteLine("Please enter Fah value");
                f = Convert.ToDouble(Console.ReadLine());

                ftemp.setFahrenheit(f);
                Console.WriteLine($"F:{ftemp.getFahrenheit()});
            } while (f != 0);

            MovablePoint m1 = new MovablePoint(5, 6, 10, 15); // upcast

            Console.WriteLine(m1);

            m1.MoveLeft();

            Console.WriteLine(m1);

            MovableCircle m2 = new MovableCircle(1, 2, 3, 4, 20); // upcast

            Console.WriteLine(m2);

            m2.MoveRight();

            Console.WriteLine(m2);
        }
    }
}
