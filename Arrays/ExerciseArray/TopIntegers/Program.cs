using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] topIntegers=new int[arr.Length];
            int topIntegersIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int cuurentNum=arr[i];
                bool isTopInteger = true;
                for (int j = i+1; j <=arr.Length-1 ; j++)
                {
                    int nextNum=arr[j];
                    if (cuurentNum<=nextNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    topIntegers[topIntegersIndex] = cuurentNum;
                    topIntegersIndex++;
                }
            }
            for (int i = 0; i < topIntegersIndex ; i++)
            {
                Console.Write($"{topIntegers[i]} ");
            }
        }
    }
}
