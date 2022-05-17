using System;
using System.Collections.Generic;
using System.Text;

namespace PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal usd = pounds * 1.31M;
            Console.WriteLine($"{usd:f3}");
        }
    }
}
