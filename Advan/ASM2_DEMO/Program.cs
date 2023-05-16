using ASM2_DEMO.Decorator;
using ASM2_DEMO.GiftBasket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_DEMO
{
    public class Program
    {
        public static List<ITetGiftBasket> iTetGiftBasket = new List<ITetGiftBasket>();
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("-------------MENU--------------");
                    Console.WriteLine("| 1. Choose HealthGiftBasket  |");
                    Console.WriteLine("| 2. Choose WarmGiftBasket    |");
                    Console.WriteLine("| 3. Choose TetGiftBasket     |");
                    Console.WriteLine("| 0. Exit                     |");
                    Console.WriteLine("-------------------------------");
                    Console.Write("Enter your choose: ");
                    int gb = Convert.ToInt32(Console.ReadLine());
                    switch(gb)
                    {
                        case 1:
                            Console.WriteLine("You choose HealthGiftBasket");
                            HealthGiftBasket Hg = new HealthGiftBasket();
                            Add(Hg);
                            break;
                        case 2:
                            Console.WriteLine("You just chose WarmGiftBasket");
                            WarmGiftBasket Wg = new WarmGiftBasket();
                            Add(Wg);
                            break;
                        case 3:
                            Console.WriteLine("You choose TetGiftBasket");
                            TetGiftBasket Tg = new TetGiftBasket();
                            Add(Tg);
                            break;
                        case 0:
                            Console.WriteLine("--------------------");
                            Console.WriteLine("\n Exit program ");
                            Console.WriteLine("--------------------");
                            return;

                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Your choice is incorrect !");
                    Console.WriteLine("--------------------------");
                }
            }

            static void Add(ITetGiftBasket tetGiftBasket)
            {
                try
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("| 1. Add Snacks           |");
                    Console.WriteLine("| 2. Add Wine             |");
                    Console.WriteLine("| 3. Add KindOfSpice      |");
                    Console.WriteLine("| 4. Add FunctionalFoods  |");
                    Console.WriteLine("| 5. Return               |");
                    Console.WriteLine("| 0. Exit                 |");
                    Console.WriteLine("---------------------------");
                    Console.Write("Enter your choose: ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    switch (a)
                    {
                        case 1:
                            Console.WriteLine("You've added Snacks");
                            tetGiftBasket = new Snacks(tetGiftBasket);
                            break;
                        case 2:
                            Console.WriteLine("You've added Wine");
                            tetGiftBasket = new Wine(tetGiftBasket);
                            break;
                        case 3:
                            Console.WriteLine("You've added KindOfSpice");
                            tetGiftBasket = new KindsOfSpice(tetGiftBasket);
                            break;
                        case 4:
                            Console.WriteLine("You've added FunctionFoods");
                            tetGiftBasket = new FunctionalFoods(tetGiftBasket);
                            break;
                        case 5:
                            Console.WriteLine("Return menu");
                            break;
                        default:
                            break;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Your choice is incorrect !");
                    Console.WriteLine("--------------------------");
                }
                iTetGiftBasket.Add(tetGiftBasket);
            }
            
        }
                
            
         
    }
}
