using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession01
{
    internal class Ex03
    {
        public Ex03() 
        {
            //C1
            //var bt = 0b1011; // binary number
            //Console.WriteLine(bt);

            //C2
            //convert binary number to decimal number
            string nb = Console.ReadLine(); //11001011
            int result = 0;
            int count = 1;
            for(int i = nb.Length-1; i>=0; i--)
            {
                //Console.WriteLine(nb[i]);
                //result += Int32.Parse(nb[i].ToString()) * count;
                result= (nb[i] - '0') * count;
                //Console.WriteLine(nb[i]+ " !!! " + result + " !!! " + count);
                count *= 2;
            }    
            Console.WriteLine("Result = " + result);
        }
    }
}
