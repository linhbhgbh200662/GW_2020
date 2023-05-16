using Decorator.Model;
using Decorator.Model.ConcreteComponents;
using Decorator.Model.ConcreteDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("| 1. Choose Snacks         |");
                    Console.WriteLine("| 2. Choose Wine           |");    
                    Console.WriteLine("| 3. Choose KindOfSpice    |");
                    Console.WriteLine("| 4. Choose FunctionalFoods|");
                    Console.WriteLine("| 0. Exit                  |");
                    Console.WriteLine("----------------------------");
                    Console.Write("Enter your choose ");
                    int key = Convert.ToInt32(Console.ReadLine());
                    switch (key)
                    {
                        case 1:
                            Console.WriteLine("--------------------");
                            Console.WriteLine("You choose Snacks);
                            Snacks s = new Snacks();
                            Decorator.ConcreteDecorators.Snacks(s);
                            IEspresso cappuccino = cappu.build();
                            Console.WriteLine(cappuccino);
                            espressos.Add(cappuccino);
                            Console.WriteLine("--------------------");
                            break;
                        case 2:
                            Console.WriteLine("--------------------");
                            Console.WriteLine("You choose Wine");
                            Console.WriteLine("--------------------");
                            Wine w = new Wine();
                            Decorator.ConcreteDecorators.Wine(w);
                            IEspresso americano = ame.build();
                            Console.WriteLine(americano);
                            espressos.Add(americano);
                            Console.WriteLine("--------------------");
                            break;
                        case 3:
                            Console.WriteLine("--------------------");
                            Console.WriteLine("You choose KindsOfSpice");
                            Console.WriteLine("--------------------");
                            KindsOfSpice kos = new KindsOfSpice();
                            Decorator.ConcreteDecorators.KindsOfSpice(kos);
                            IEspresso latte = lat.build();
                            Console.WriteLine(latte);
                            espressos.Add(latte);
                            Console.WriteLine("--------------------");
                            break;
                        case 4:
                            Console.WriteLine("--------------------");
                            Console.WriteLine("You choose FunctionalFoods");
                            Console.WriteLine("--------------------");
                            FunctionalFoods ff = new FunctionalFoods();
                            Decorator.ConcreteDecorators.FunctionalFoods(ff);
                            IEspresso latte = lat.build();
                            Console.WriteLine(latte);
                            espressos.Add(latte);
                            Console.WriteLine("--------------------");
                        case 5:
                            int countcapu = 0;
                            int countame = 0;
                            int countlat = 0;
                            DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                            foreach (IEspresso em in espressos)
                            {
                                if (em.GetTime() <= DateTime.Now && em.GetTime() >= dt)
                                {
                                    if (em.GetType() == "Cappuccino")
                                    {
                                        countcapu++;
                                    }
                                    else if (em.GetType() == "Americano")
                                    {
                                        countame++;
                                    }
                                    else if (em.GetType() == "Latte")
                                    {
                                        countlat++;
                                    }
                                }
                            }
                            Console.WriteLine("--------------------");
                            Console.WriteLine("Cappuccino: " + countcapu);
                            Console.WriteLine("Americano: " + countame);
                            Console.WriteLine("Latte: " + countlat);
                            Console.WriteLine("--------------------");
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
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Your choice is incorrect !");
                    Console.WriteLine("--------------------");
                }
            }
        }
    }
    
}
