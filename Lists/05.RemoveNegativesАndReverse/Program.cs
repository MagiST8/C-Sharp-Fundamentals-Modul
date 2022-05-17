using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RemoveNegativesАndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.RemoveAll(n => n < 0);//премахва всички негативни числа в листа
            if (numbers.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                numbers.Reverse();//сортира числата в обратен ред
                Console.WriteLine(String.Join(" ",numbers));
            }
        }
    }
}
