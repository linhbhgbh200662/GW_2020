using AsmAdvanPro;
using System;
using System.Collections.Generic;
using System.Text;


namespace AsmAdvanPro.asm
{
    class LakeProgram
    {
        public static abLake lake;
        public static abLake laketg;
        public static void Main(string[] args)
        {
            //abLake myLake = new Lake1();
            //myLake = new Carp(myLake);
            //Lake1 lake1 = new Lake1();
            //Lake2 lake2 = new Lake2();
            //Carp carp = new Carp(myLake);
            //Console.WriteLine("Welcome...");
            //int a=1;
            //int b;
            //bool kt = false;
            //do       
            int a;
            int abc = 1;
            bool kt = false;
            int dem = 0;
            Console.WriteLine("***************** Welcome to my aplication. *****************");
            Console.WriteLine("***************** Chose your option, pls.   *****************");
            Console.WriteLine("***************** 1.Chose lake.             ***************** ");
            Console.WriteLine("***************** 2.Add frish to lake.      *****************");
            Console.WriteLine("Your option: ");
            do
            {
                if (abc == 0)
                {
                    Console.WriteLine("***************** Enter again, pls. *****************");
                }
                try
                {
                    do
                    {
                        if (dem != 0)
                        {
                            Console.WriteLine("1.Chose lake again. ");
                            Console.WriteLine("2.Add frish to lake.");
                        }
                        dem = 1;
                        a = chose();
                        switch (a)
                        {
                            case 1:
                                Console.WriteLine("ID of lake ?:");
                                enterid();
                                kt = true;
                                break;
                            case 2:
                                if (kt == false)
                                {
                                    Console.WriteLine("You not chose Lake to fish.");
                                    continue;
                                }
                                add();
                                break;
                            default:
                                break;
                        }
                    } while (a != 0);
                }
                catch (System.Exception e)
                {
                    abc = 0;
                    Console.WriteLine("Wrong:");
                    Console.WriteLine(e.Message);
                }
            } while (abc != 1);
        }
        static public int chose()
        {
            int a = int.Parse(Console.ReadLine());
            while ((a > 2) || (a < 0))
            {
                Console.WriteLine("Enter again.");
                a = int.Parse(Console.ReadLine());
            }
            return a;
        }
        static public void enterid()
        {
            int b = Convert.ToInt32(Console.ReadLine());
            switch (b)
            {
                case 1:
                    Console.WriteLine("you chose lake:");
                    lake = new Lake1();
                    Console.WriteLine(lake);
                    break;
                case 2:
                    Console.WriteLine("you chose lake:");
                    lake = new Lake2();
                    Console.WriteLine(lake);
                    break;
            }
        }
        static public void add()
        {
            Console.WriteLine("***************** You chosed add firsh. *****************");
            Console.WriteLine("***************** 1. Add Crap fish.     *****************");
            Console.WriteLine("***************** 2. Add Tilaphia fish. *****************");
            Console.WriteLine("***************** 3. Add Catfish fish.  *****************");
            Console.WriteLine("Your option: ");
            int b = Convert.ToInt32(Console.ReadLine());
            switch (b)
            {
                case 1:
                    Console.WriteLine("You chose add Crap firsh:");
                    Console.WriteLine("- With: " + lake);
                    laketg = lake;
                    laketg = new Carp(laketg);
                    if (laketg.CheckKind() != ktkind() && ktkind() != 0)
                    {
                        Console.WriteLine("The fish in the pond can't live together.");
                        break;
                    }
                    lake = new Carp(lake);
                    Console.WriteLine("-Added 10kg of Crap fish :");
                    Console.WriteLine(lake);
                    ktlake();
                    Console.WriteLine("-Cost to make:");
                    Console.WriteLine(lake.CaculateTotalCost());
                    break;
                case 2:
                    Console.WriteLine("You chose add Tilaphia fish:");
                    Console.WriteLine("With lake: " + lake);
                    laketg = lake;
                    laketg = new Tilaphia(laketg);
                    if (laketg.CheckKind() != ktkind() && ktkind() != 0)
                    {
                        Console.WriteLine("The fish in the pond can't live together.");
                        break;
                    }
                    lake = new Carp(lake);
                    Console.WriteLine(" Added 10kg of Tilaphia fish :");
                    Console.WriteLine(lake);
                    ktlake();
                    Console.WriteLine("CSost to make:");
                    Console.WriteLine(lake.CaculateTotalCost());
                    break;
                case 3:
                    Console.WriteLine("You chose add Catfish firsh:");
                    Console.WriteLine("With lake: " + lake);
                    laketg = lake;
                    laketg = new Catfish(laketg);
                    if (laketg.CheckKind() != ktkind() && ktkind() != 0)
                    {
                        Console.WriteLine("The fish in the pond can't live together.");
                        break;
                    }
                    lake = new Carp(lake);
                    Console.WriteLine(" Added 10kg of Catfish fish :");
                    Console.WriteLine(lake);
                    ktlake();
                    Console.WriteLine("Cost to make:");
                    Console.WriteLine(lake.CaculateTotalCost());
                    break;
                case 0:
                    break;
            }
        }
        public static void ktlake()
        {
            if (lake.CheckLake() > 0)
            {
                Console.WriteLine("Lake have" + lake.CheckLake() + " space to add first.");
            }
            else Console.WriteLine("Warning: TOO MUCH: Lake is missing " + lake.CheckLake() + " space to add first.");
        }
        public static double ktkind()
        {
            return lake.CheckKind();
        }
    }
}



