using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession01
{
    // input 3 numbers, then find the maximum value among these numbers
    internal class Ex01
    {
        public Ex01()
        {
            // input 3 numbers, then find the maximum value among these numbers
            int a, b, c; // khai bao
            //a = 0; // gán
            Console.Write("a = ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = Int32.Parse(Console.ReadLine());
            // -----Process----
            int max;
            //if(a > b)
            //    max = a;
            //else
            //    max= b;
            //.....
            //max = a;
            //if (max < b)
            //    max = b;
            //if (max < c)
            //    max = c;
            //...
            max = Int32.MinValue;
            if (max < a)
                max = a;
            if (max < b)
                max = b;
            if (max < c)
                max = c;
            //.....
            Console.WriteLine("Maximum value is: " + max);
        }
    }
}
