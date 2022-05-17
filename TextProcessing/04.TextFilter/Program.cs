using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] bannedWord=Console.ReadLine().Split(new char[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries);
            string text=Console.ReadLine();
            foreach (var word in bannedWord)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
