using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();
            Dictionary<string, int> occuriences = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string lowerCase = word.ToLower();

                if (occuriences.ContainsKey(lowerCase))
                {
                    occuriences[lowerCase] += 1;
                }
                else
                {
                    occuriences.Add(lowerCase, 1);
                }
            }
            foreach (var item in occuriences)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
            Console.WriteLine();

        }
    }
}
