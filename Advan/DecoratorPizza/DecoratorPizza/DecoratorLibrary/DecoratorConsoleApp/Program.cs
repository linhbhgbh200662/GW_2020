using DecoratorLibrary;
using DecoratorLibrary.ConnectDecorator;
using DecoratorLibrary.Pizza;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorConsoleApp
{
	public class Program
	{
		public static List<IPizza> lpizza = new List<IPizza>();
		static void Main(string[] args)
		{
			BeefyPizza b = new BeefyPizza();
			IPizza i = new BeefyPizza();

			CheckenPizza c = new CheckenPizza();

			Console.WriteLine(c.Description());
			Console.WriteLine(b.Description());
			Console.WriteLine("Cost: " + b.GetCost() + "Size" + b.Size);

			int choice;
			do
			{
				Console.WriteLine("--------Menu-------");
				Console.WriteLine("1. Checken Pizza");
				Console.WriteLine("2. Tomato Pizza");
				Console.WriteLine("3. Beefy Pizza");
				Console.WriteLine("4. List invoices");
				Console.WriteLine("5. Exit");
				do
				{
					try
					{
						choice = int.Parse(Console.ReadLine());
						if (choice < 0 || choice > 6)
						{
							Console.WriteLine("Enter a valid number");
						}
					}
					catch (System.Exception)
					{
						choice = -1;
						Console.WriteLine("Invalid number");
						Console.WriteLine("Enter a valid number");
					}


				} while (choice < 0 || choice > 6);


				switch (choice)
				{
					case 1:
						Console.WriteLine("You just chose Chicken pizza");
						CheckenPizza ck = new CheckenPizza();
						Add(ck);
						break;
					case 2:
						Console.WriteLine("You just chose Tomato Pizza");
						TomatoPizza tm = new TomatoPizza();
						Add(tm);
						break;
					case 3:
						Console.WriteLine("You just chose Beefy Pizza");
						BeefyPizza bf = new BeefyPizza();
						Add(bf);
						break;
					case 4:
						Console.WriteLine("You chose display invoice");
						DisplayInvoice(lpizza);
						break;
					case 5:
						Console.WriteLine("You chose exit");
						return;
					default:
						Console.WriteLine("Choose again");
						break;

				}

			} while (choice != 5);

		}

		public static void DisplayInvoice(List<IPizza> pizzas)
		{
			decimal total = 0;
			for (int i = 0; i < pizzas.Count; i++)
			{
				total += pizzas[i].GetCost();
			}
			Console.WriteLine(" --------------------------- ");
			Console.WriteLine("Total price : ${0}", total);
		}

		static void Add(IPizza inner)
		{
			int choice;
			do
			{
				Console.WriteLine("1. Chesse");
				Console.WriteLine("2. Ham");
				Console.WriteLine("3. Pepper");
				Console.WriteLine("4. Return");
				Console.Write("Select : ");
				do
				{
					try
					{
						choice = int.Parse(Console.ReadLine());
						if (choice < 0 || choice > 6)
						{
							Console.WriteLine("Enter a valid number");
						}
					}
					catch (System.Exception)
					{
						choice = -1;
						Console.WriteLine("Invalid number");
					}


				} while (choice < 0 || choice > 6);

				switch (choice)
				{
					case 1:
						Console.WriteLine("You've added Cheese to your pizza");
						inner = new Cheese(inner);
						break;
					case 2:
						Console.WriteLine("You've added Ham to your pizza");
						inner = new Ham(inner);
						break;
					case 3:
						Console.WriteLine("You've added Pepper to your pizza");
						inner = new Pepper(inner);
						break;
					case 4:
						Console.WriteLine("Return menu");
						break;
					default:
						break;
				}

			} while (choice != 4);
			lpizza.Add(inner);
			Console.WriteLine("{0},Total Price: {1}", inner.Description(),inner.GetCost());

		}
	}
}
