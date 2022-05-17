using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();//четем продуктите от конзолата
                products.Add(product);// добавяме ги към листа(products)
            }
            products.Sort();// сортира продуктите, които са в листа
            for (int i = 0; i < products.Count; i++)//въртим цикъл, в който четем броя продукти
            {
                Console.WriteLine($"{i+1}.{products[i]}");//печатаме ги
            }
        }
    }
}
