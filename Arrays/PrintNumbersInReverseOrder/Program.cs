using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[] items = new int[n];
            for (int i = 0; i < n; i++)
            {
                items[i]=int.Parse(Console.ReadLine()); 
            }
            for (int i = items.Length-1; i >=0; i--)
            {
                Console.Write($"{items[i]} ");
            }
        }
    }
}
