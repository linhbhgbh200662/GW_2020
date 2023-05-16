using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession01
{
    internal class Ex04
    {
        public Ex04() 
        {
            int n = 203;
            //Expected output: 11001011
            //C1
            string str = "";
            
            do
            {
                str += (n % 2); //11010011, reversed
                n = n / 2;

            }
            while (n != 0);

            for(int i = str.Length-1; i>=0; i--) 
            {
                Console.Write(str[i]); //11001011
            }

            //C2
            int[] result = new int[32];
            int idx = 0;
            do
            {
                result[idx] = n % 2;
                idx++;
                n = n / 2;
            }    
            while(n != 0);
            //Console.WriteLine(result.ToString());

            for(int i = result.Length-1; i>=0; i--)
            {
                Console.Write(result[i]);  //11001011
            }
        }
    }
}
