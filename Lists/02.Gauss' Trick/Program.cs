using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last - n.

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {

                int lastNum = numbers[i] + numbers[numbers.Count - 1-i];
                result.Add(lastNum);

            }
            if (numbers.Count % 2 != 0)
            {
                result.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
