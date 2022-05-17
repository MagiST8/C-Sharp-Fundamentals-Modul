using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Join("",GetString(str,count)));
        }
        static string GetString(string str, int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result +=str;
            }
            return result;
        }
    }
}
