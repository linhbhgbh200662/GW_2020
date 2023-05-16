using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession04
{
    internal class Ex01
    {
        public int id;
        public string name;
        public string batch;
        public string email;
        public bool gender = true;

        // None of these properties contains a particular value in the definition of class student
        //Diffirent objects/instances will have a different set values for these

        //Constructor
        public Ex01()
        {
            // gender
        }

        public Ex01(int id, string name) //parameterizaed constructor
        {

        }

        //Using parameterized constructor when you want to
         // force 

        //public Students(int x, int y)
        //{
        //    id = x;
        //    name = y;
        //    email = generate(id, name);
        //}

        //public Students(int id, string name)
        //{
        //    this.id = id;
        //    this.name = name;
        //}



        //behaviours
        //public bool registerACourse(Course c)
        //{
        //    //.....
        //    return false;
        //}
    }

    
}
