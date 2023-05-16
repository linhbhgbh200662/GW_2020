using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GCH1006_RT_Lesson05
{
    internal class Student
    {
        //Object's properties
        public int id;
        public string name;
        //public bool gender;
        private bool gender;

        public bool Gender
        {
            get { return gender; }
            set {
                if (gender && !value) 
                    count_male--;
                else if(!gender && value)  
                    count_male++;
                gender = value; 
            }
        }

        public string address;
        //Class's property
        //public static int count_male = 0;
        private static int count_male;

        public static int Count_Male
        {
            get { return count_male; }
        }


        public Student(int id, string name, bool gender, string address)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.address = address;
            if (gender) count_male++;
        }

        public void print()
        {
            Console.WriteLine("{0,-4} | {1,-20} | {2,-7} | {3,-20}"
                , id, name, (gender) ? "Male" : "Female", address);
        }
    }
}
