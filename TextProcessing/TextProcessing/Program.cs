using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] allWords = Console.ReadLine().Split().ToArray();

            string result = "";

            foreach (string word in allWords)//думите ще се подават една по една в цикъла
            {
                for (int i = 0; i < word.Length; i++)//ще завърди думата толкова пъти, колкото символа има самата дума
                {
                    result += word;//конкатенираме думите
                }
            }
            Console.WriteLine(result);
        }
    }
}
