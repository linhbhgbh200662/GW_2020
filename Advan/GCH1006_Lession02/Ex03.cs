using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession02
{
    internal class Ex03
    {
        // 1 số
        // arr[] = {6, 7, 9, 10, 11}
        // vòng lặp int i = 6 -> 11: sum_real = 
        // sum = 6+7+9+10+11
        // sum_real - sum 
        public Ex03() 
        {
            ///C1
            //int[] arr = { 6, 7, 9, 10, 11 };
            //int sum = 0;
            //int sum_real = 0;
            //int f_num = 6;
            //int l_num = 11;
            //int b;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}
            //for (int i = f_num; i <= l_num; i++) 
            //{
            //    sum_real += i;
            //}
            //b = sum_real - sum;
            //Console.WriteLine(b);


            //C2
            int[] arr = { 6, 7, 9, 10, 11 };
            int sum_full = 0;
            for(int i = arr[0]; i <= arr[arr.Length - 1]; i++) 
            {
                sum_full += i;
            }
            int sum_real = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum_real += arr[i];
            }
            if(sum_full > sum_real)
            {
                Console.WriteLine("Missing value is: " + (sum_full - sum_real));
            }    
        }
    }
}
