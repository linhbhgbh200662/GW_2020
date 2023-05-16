using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession02
{
    internal class Ex04
    {
        // given an sorted array/list, find missing elements in the array
        //E.g. arr[] = {6, 10, 11, 12, 15, 17, 20}
        // -> Output: 7, 8, 9, 13, 14, 16, 18, 19

        //i= 0 1  2  3  4  5  6
        //   6 10 11 12 15 17 20
        // diff = arr[0] -0
        //      = 6
        //(diff+i) < arr[i]
        //  7         10
        public Ex04()
        {
            int[] arr = { 6, 10, 11, 12, 15, 17, 20 };
            int diff = arr[0] - 0;
            //int count = 0;
            for(int i = 0; i < arr.Length; i++) 
            {
                int count = 0;
                while(diff + count < arr[i] - 1)
                {
                    count++;
                    Console.WriteLine(diff + count);
                }
                diff = arr[i];
            }

            /////// C2
            //int[] arr = { 6, 10, 11, 12, 15, 17, 20 };
            //int diff = arr[0] - 0;
            ////int count = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int count = 1;
            //    while (diff + count < arr[i])
            //    {
                    
            //        Console.WriteLine(diff + count);
            //        count++;
            //    }
            //    diff = arr[i];
            //}
        }
    }
}
