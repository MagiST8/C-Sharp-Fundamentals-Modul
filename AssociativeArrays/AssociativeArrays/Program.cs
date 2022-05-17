using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociativeArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers=Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            SortedDictionary<int,int> occurencies=new SortedDictionary<int,int>();

            foreach (int number in numbers)
            {
                if (occurencies.ContainsKey(number))
                {
                    occurencies[number] += 1;
                }
                else
                {
                    occurencies.Add(number, 1);
                }
            }
            foreach (var item in occurencies)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
