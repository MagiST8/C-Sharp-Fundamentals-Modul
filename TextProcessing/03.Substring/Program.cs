using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove=Console.ReadLine();
            string text=Console.ReadLine();

            while (text.Contains(wordToRemove))
            {
                int startIndex = text.IndexOf(wordToRemove);
                text=text.Remove(startIndex, wordToRemove.Length);

            }
            Console.WriteLine(text);
        }
    }
}
