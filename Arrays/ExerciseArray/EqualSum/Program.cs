using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            bool isFound = false;
            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }
                int rightSum = 0;
                for (int k =arr.Length-1; k>i; k--)
                {
                    rightSum += arr[k];

                }
                if (leftSum==rightSum)
                {
                    Console.WriteLine(i);
                        isFound = true;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
