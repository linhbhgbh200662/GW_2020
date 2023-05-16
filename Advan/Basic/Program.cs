using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input 3 numbers, then find the maximum value among these numbers
            int a,b,c; // khai bao
            //a = 0; // gán
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            c = Int32.Parse(Console.ReadLine());
            // -----Process----
            int max;
            //if(a > b)
            //    max = a;
            //else
            //    max= b;
            //.....
            max = a;
            if(max < b)
                max = b;
            if(max < c)
                max = c;
            //...
            Console.WriteLine("Maximum value is: " + max);
            

           

            

        }
    }
}
