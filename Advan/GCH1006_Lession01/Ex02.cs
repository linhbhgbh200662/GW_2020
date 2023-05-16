using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession01
{
    // iput n numbers, find the maximum value
    //(without using array)
    internal class Ex02
    {
        public Ex02() 
        {
            //------Input----------
            Console.Write("Enter a number: ");
            int n = Int32.Parse(Console.ReadLine());

            //-------Process-------
            int max = Int32.MinValue;
            for(int i = 0; i < n; i++)  // run n times, each iteration step(bước lặp) the user will input one number
            {
                int temp = Int32.Parse(Console.ReadLine());
                if(temp > max) 
                    max = temp;
            }    

            //------Output---------
            Console.WriteLine("Maximum value is: " + max);
        }
    }
}
