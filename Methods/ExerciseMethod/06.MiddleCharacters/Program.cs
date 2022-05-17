using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(FindMiddleCharacter(text));

        }
        static string FindMiddleCharacter(string text)
        {
            int lenght = 1 - text.Length % 2;
            return text.Substring(text.Length / 2 - lenght, 1 + lenght);
        }       
    }
}
