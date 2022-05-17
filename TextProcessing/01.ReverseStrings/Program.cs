using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command!="end")
            {
                char[] wordArr = command.ToCharArray();
                Array.Reverse(wordArr);
                string result = new string(wordArr);
                Console.WriteLine($"{command} = {result}");

                command = Console.ReadLine();
            }
        }
    }
}
 