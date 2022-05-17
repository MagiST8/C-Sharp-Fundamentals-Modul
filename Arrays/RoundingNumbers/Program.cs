using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine().Split();
            double[] items = new double[n.Length];
            for (int i = 0; i < n.Length; i++)
            {
                items[i] = double.Parse(n[i]);
            }
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{items[i]} => {Math.Round(items[i], MidPoindRounding.AwayFromZero)}");
            }


        }
    }
}
