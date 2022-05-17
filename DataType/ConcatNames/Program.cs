using System;
using System.Collections.Generic;
using System.Text;

namespace ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string sybmol=Console.ReadLine();
            Console.WriteLine($"{first}{sybmol}{second}");
        }
    }
}
