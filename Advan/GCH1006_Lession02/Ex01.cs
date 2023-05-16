using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession02
{
    internal class Ex01
    {
        public Ex01()
        {
            //Review array in C#
            int x;
            int[] arr; //khai báo(Declaration statement

            arr = new int[10]; // khởi tạo 1 mảng mà nó bao gồm  10 phần tử, all các gtri đều đang = 0 (Initialization an array containing 10 elements, all have default value(0)
                               // length: tổng số phần tử lưu trữ trong array (total number of elements can be stored in the array

            int[] brr = { 6, 8, 12, 42, 56, 66, 72, 88, 99 };
            x = 9; // asignment statement

            if (x == 5)
            {
                Console.WriteLine("Hello");
            }
            x = x + 12;

            int y = 0; // khai báo và khỏi tạo (Declaration & Initialization statement

            Console.WriteLine(x);   // Compile-time error
            Console.WriteLine(arr.Length); //10
            Console.WriteLine(arr[0]); //0

            //--------------------Input------------------------
            // -- Use phép gán (Asignment statement
            arr[2] = 15; // cố định
            arr[3] = Int32.Parse(Console.ReadLine()); // lấy từ bàn phím (read from the user's input on 
            
            Random rd = new Random(); 
            arr[4] = rd.Next(); // sinh ra 1 giải số ngẫu nhiên từ [0, Int32.MaxValue)
            arr[5] = rd.Next(10, 21);  //[10, 21)
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(10, 21);
            }    

                //--------------------Output-----------------------
                Console.WriteLine("Print all elements in the array");
            for (int i = 0; i<brr.Length; i++) 
            {
                Console.Write(brr[i] + " ");
            }
            Console.WriteLine();

            //.....
            foreach(int each in brr)
            {
                Console.Write(each + " ");
            }    
            Console.WriteLine();

            //.....
            Console.WriteLine(string.Join(", ", brr));
            // string result = string.Join(", ", brr);
            // Console.WriteLine(result);
        }
    }
}
