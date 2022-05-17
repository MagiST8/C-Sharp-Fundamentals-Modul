using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            PrintOrders(product, quantity);

        }

        static void PrintOrders(string product, int quantity)
        {
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.50 * quantity;
                    Console.WriteLine($"{price:f2}");
                    break;
                case "water":
                    price = 1.00 * quantity;
                    Console.WriteLine($"{price:f2}");
                    break;
                case "coke":
                    price = 1.40 * quantity;
                    Console.WriteLine($"{price:f2}");
                    break;
                case "snacks":
                    price = 2.00 * quantity;
                    Console.WriteLine($"{price:f2}");
                    break;
                default:
                    break;
            }
        }
    }
}
