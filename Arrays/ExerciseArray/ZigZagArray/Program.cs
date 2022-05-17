using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZagArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] currentData = Console.ReadLine().Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).
                    ToArray();
                int numberFirst = currentData[0];
                int numberSecond = currentData[1];
                if (i%2!=0)
                {
                    arr1[i - 1] = numberFirst;
                    arr2[i - 1] = numberSecond;
                }
                else
                {
                    arr1[i - 1 ]= numberSecond;
                    arr2[i - 1] = numberFirst;
                }
            }
            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ",arr2));
        }
    }
}
