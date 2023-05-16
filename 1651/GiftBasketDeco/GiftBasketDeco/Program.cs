using GiftBasketDeco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBasketDeco
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------------MENU--------------");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("| 1. Choose HealthGiftBasket  |");
            Console.WriteLine("| 2. Choose WarmGiftBasket    |");
            Console.WriteLine("| 3. Choose TetGiftBasket     |");
            Console.WriteLine("| 0. Exit                     |");
            Console.WriteLine("-------------------------------");
            Console.Write("Enter your choose: ");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("You choose HealthGiftBasket");
                    Console.WriteLine("---------------------------");
                    Hg = new HealthGiftBasket();
                    Console.WriteLine(Hg.CalcuateCost());
                    break;
                case 2:
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("You choose WarmGiftBasket  ");
                    Console.WriteLine("---------------------------");
                    Wg = new WarmGiftBasket();
                    Console.WriteLine(Wg.CalcuateCost());
                    break;
                case 3:
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("You choose TetGiftBasket   ");
                    Console.WriteLine("---------------------------");
                    Tg = new TetGiftBasket();
                    Console.WriteLine(Tg.CalcuateCost());
                    break;
                case 0:
                    Console.WriteLine("--------------------");
                    Console.WriteLine("\n Exit program     ");
                    Console.WriteLine("--------------------");
                    return;
            }
            Console.WriteLine("");
            try
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("| 1. Add Snacks           |");
                Console.WriteLine("| 2. Add Wine             |");
                Console.WriteLine("| 3. Add KindOfSpice      |");
                Console.WriteLine("| 4. Add FunctionalFoods  |");
                Console.WriteLine("| 0. Exit                 |");
                Console.WriteLine("---------------------------");
                Console.Write("Enter your choose: ");
                int gb = Convert.ToInt32(Console.ReadLine());
                switch (gb)
                {
                    case 1:
                        Console.WriteLine("--------------------");
                        Console.WriteLine("You choose Snacks");
                            
                        break;
                    case 2:
                        Console.WriteLine("--------------------");
                        Console.WriteLine("You choose Wine");
                            
                        break;
                    case 3:
                        Console.WriteLine("--------------------");
                        Console.WriteLine("You choose KindsOfSpice");
                            
                        break;
                    case 4:
                        Console.WriteLine("--------------------");
                        Console.WriteLine("You choose FunctionalFoods");
                            
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
    }
}

}

