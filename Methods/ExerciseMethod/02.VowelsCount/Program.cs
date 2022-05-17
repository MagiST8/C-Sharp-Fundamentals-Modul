using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a e u o i 
            string text = Console.ReadLine();
            int vowels = GetVowels(text);
            Console.WriteLine(vowels);

        }
        static int GetVowels(string text)
        {
            char[] vowels = new char[] {'a', 'e', 'u', 'o', 'i' };
            int count = 0;
            foreach (char ch in text)
            {
                if (vowels.Contains(char.ToLower(ch)))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
