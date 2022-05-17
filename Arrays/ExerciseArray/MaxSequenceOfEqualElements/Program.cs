using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]arr=Console.ReadLine().Split(' ').Select(int.Parse)
                .ToArray();
            int cnt = 1;
            int dublicate = 0;
            int index = arr[0];
            int best = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == index)
                {
                    cnt++;
                }
                else
                {
                    index=arr[i];
                    cnt = 1;
                }
                if (cnt>best)
                {
                    best = cnt;
                    dublicate = arr[i];
                }
            }
            for (int i = 0; i <best; i++)
            {
                Console.Write($"{dublicate} ");
            }
        }
    }
}
