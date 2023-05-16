using GiftBasketDeco.Decorator;
using GiftBasketDeco.GiftBasket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GiftBasketDeco
{
    public class Program
    {

        public static void Main(string[] args)
        {
            ITetGiftBasket Hg = new HealthGiftBasket();
            ITetGiftBasket Wg = new WarmGiftBasket();
            ITetGiftBasket Tg = new TetGiftBasket();

            while (true)
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
                    int gb = Convert.ToInt32(Console.ReadLine());

                    switch (gb)
                    {
                        case 1:
                            Console.WriteLine("--------------------");
                            Console.WriteLine("You choose Snacks");
                            Console.WriteLine("--------------------");
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("| 1. Choose HealthGiftBasket  |");
                            Console.WriteLine("| 2. Choose WarmGiftBasket    |");
                            Console.WriteLine("| 3. Choose TetGiftBasket     |");
                            Console.WriteLine("| 0. Exit                     |");
                            Console.WriteLine("-------------------------------");
                            Console.Write("Enter your choose: ");
                            int S = Convert.ToInt32(Console.ReadLine());
                            switch(S) 
                            { 
                                case 1:
                                    Hg = new Snacks(Hg);
                                    Console.WriteLine(Hg.GetDescription());
                                    Console.WriteLine(Hg.GetCalcuateCost());
                                    break;
                                case 2:
                                    Wg = new Snacks(Wg);
                                    Console.WriteLine(Wg.GetDescription());
                                    Console.WriteLine(Wg.GetCalcuateCost());
                                    break;
                                case 3:
                                    Tg = new Snacks(Tg);
                                    Console.WriteLine(Tg.GetDescription());
                                    Console.WriteLine(Tg.GetCalcuateCost());
                                    break;
                                 case 0:
                                    Console.WriteLine();
                                    break;
                            }

                            Console.WriteLine("--------------------");
                                
                            break;
                        case 2:
                            Console.WriteLine("--------------------");
                            Console.WriteLine("You choose Wine     ");
                            Console.WriteLine("--------------------");
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("| 1. Choose HealthGiftBasket  |");
                            Console.WriteLine("| 2. Choose WarmGiftBasket    |");
                            Console.WriteLine("| 3. Choose TetGiftBasket     |");
                            Console.WriteLine("| 0. Exit                     |");
                            Console.WriteLine("-------------------------------");
                            Console.Write("Enter your choose: ");
                            int W = Convert.ToInt32(Console.ReadLine());
                            switch (W)
                            {
                                case 1:
                                    Hg = new Wine(Hg);
                                    Console.WriteLine(Hg.GetDescription());
                                    Console.WriteLine(Hg.GetCalcuateCost());
                                    break;
                                case 2:
                                    Wg = new Wine(Wg);
                                    Console.WriteLine(Wg.GetDescription());
                                    Console.WriteLine(Wg.GetCalcuateCost());
                                    break;
                                case 3:
                                    Tg = new Wine(Tg);
                                    Console.WriteLine(Tg.GetDescription());
                                    Console.WriteLine(Tg.GetCalcuateCost());
                                    break;
                                case 0:
                                    Console.WriteLine();
                                    break;
                            } 

                            break;
                        case 3:
                            Console.WriteLine("--------------------");
                            Console.WriteLine("You choose KindsOfSpice");
                            Console.WriteLine("--------------------");
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("| 1. Choose HealthGiftBasket  |");
                            Console.WriteLine("| 2. Choose WarmGiftBasket    |");
                            Console.WriteLine("| 3. Choose TetGiftBasket     |");
                            Console.WriteLine("| 0. Exit                     |");
                            Console.WriteLine("-------------------------------");
                            Console.Write("Enter your choose: ");
                            int K = Convert.ToInt32(Console.ReadLine());
                            switch (K)
                            {
                                case 1:
                                    Hg = new KindsOfSpice(Hg);
                                    Console.WriteLine(Hg.GetDescription());
                                    Console.WriteLine(Hg.GetCalcuateCost());
                                    break;
                                case 2:
                                    Wg = new KindsOfSpice(Wg);
                                    Console.WriteLine(Wg.GetDescription());
                                    Console.WriteLine(Wg.GetCalcuateCost());
                                    break;
                                case 3:
                                    Tg = new KindsOfSpice(Tg);
                                    Console.WriteLine(Tg.GetDescription());
                                    Console.WriteLine(Tg.GetCalcuateCost());
                                    break;
                                case 0:
                                    Console.WriteLine();
                                    break;
                            }
                            break;
                        case 4:
                            Console.WriteLine("--------------------");
                            Console.WriteLine("You choose FunctionalFoods");
                            Console.WriteLine("--------------------");
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("| 1. Choose HealthGiftBasket  |");
                            Console.WriteLine("| 2. Choose WarmGiftBasket    |");
                            Console.WriteLine("| 3. Choose TetGiftBasket     |");
                            Console.WriteLine("| 0. Exit                     |");
                            Console.WriteLine("-------------------------------");
                            Console.Write("Enter your choose: ");
                            int F = Convert.ToInt32(Console.ReadLine());
                            switch (F)
                            {
                                case 1:
                                    Hg = new FunctionalFoods(Hg);
                                    Console.WriteLine(Hg.GetDescription());
                                    Console.WriteLine(Hg.GetCalcuateCost());
                                    break;
                                case 2:
                                    Wg = new FunctionalFoods(Wg);
                                    Console.WriteLine(Wg.GetDescription());
                                    Console.WriteLine(Wg.GetCalcuateCost());
                                    break;
                                case 3:
                                    Tg = new FunctionalFoods(Tg);
                                    Console.WriteLine(Tg.GetDescription());
                                    Console.WriteLine(Tg.GetCalcuateCost());
                                    break;
                                case 0:
                                    Console.WriteLine();
                                    break;
                            }
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
