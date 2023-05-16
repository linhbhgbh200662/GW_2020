using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_RT_Lesson05
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //1. Define a class: Student (id, name, gender, address)
            //2. Create a list of N students
            //3. Calcuate the male percentage in the list created in task 2
            //4. Write a function to find those students whose name contains a given keyword

            int N = 15;
            int start = 101;
            List<Student> aList = new List<Student>(N);
            string[] names = {"Do Hong Quan", "Tran Nguyen Vu", "Nguyen Hai Nam", "Do Lan Phuong", "Nguyen Hong Van"};
            string[] addresses = { "Hanoi", "HCM City", "Hai Phong", "Ha Tinh", "Nam Dinh", "Ha Giang", "Quang Ninh" };
            for (int i=0; i<N; i++)
            {
                int id = start * (i + 1);
                //Console.Write("Input id: ");
                //int id = Int32.Parse(Console.ReadLine());
                string name = names[i % names.Length];
                bool gender = new Random().Next(2) == 1;
                string address = addresses[i % addresses.Length];
                aList.Add(new Student(id, name, gender, address));
                aList[i].print();
            }
            //Console.WriteLine(aList[2].name);
            //Console.WriteLine(Student.name);

            //Console.WriteLine(aList[2].gender);
            //Console.WriteLine(Student.gender);

            //Console.WriteLine(Student.count_male);
            /////////////////////////
            ///3. Calcuate the male percentage
            //int count_male = 0;
            //foreach(Student each in aList)
            //{
            //    if (each.gender)
            //        count_male++;
            //}
            //Console.WriteLine("Male percentage is: " 
            //    + (count_male * 1.0 / aList.Count) * 100 + "%");
            //Student.Count_Male = -1;

            Console.WriteLine("Male percentage is: "
                + (Student.Count_Male * 1.0 / aList.Count) * 100 + "%");
            aList.Add(new Student(9, "@Test", true, "Sample address"));
            aList[aList.Count - 1].print();
            Console.WriteLine("Male percentage is: "
                + (Student.Count_Male * 1.0 / aList.Count) * 100 + "%");
            aList[2].Gender = true;
            aList[2].print();
            Console.WriteLine("Male percentage is: "
               + (Student.Count_Male * 1.0 / aList.Count) * 100 + "%");
            /////////////////////
            //4. Write a function to find those students whose name contains a given keyword
            Console.WriteLine("Enter a name to be searched: ");
            string keyword = Console.ReadLine();
			List<Student> found = findStudent(aList, keyword);
			Console.WriteLine("Found: {0} student(s)", found.Count);
            foreach(Student each in found)
                each.print();
        }
        private static List<Student> findStudent(List<Student> aList, string keyword)
        {
            List<Student> found = new List<Student>();
            foreach(Student each in aList) 
            {
                if(each.name.Contains(keyword))
                {
                    found.Add(each);
                }    
            }
            return found;
        }


        private static void demo()
        {
            Teacher one = new Teacher();
            Console.WriteLine(one.Id);
            one.Id = 101;

			Console.WriteLine(one.Name);
			one.Name = "Đỗ Hồng Quân";

            Console.WriteLine(one.Address);
            one.Address = "Hanoi";

            Console.WriteLine(one.Gender);
            one.Gender = true;

            List<Int32> aList = new List<Int32>();
            aList.Count = 10;
            Console.WriteLine(aList.Count);
        }
    }
}
