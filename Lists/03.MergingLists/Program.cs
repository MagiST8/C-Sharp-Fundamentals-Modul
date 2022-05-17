using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int longerList = Math.Max(firstList.Count, secondList.Count);// намираме кой е по големия лист
            for (int i = 0; i < longerList; i++)
            {
                if (i<firstList.Count)
                {
                    result.Add(firstList[i]);
                }
                if (i<secondList.Count)
                {
                    result.Add(secondList[i]);
                }
            }
            Console.WriteLine(String.Join(" ",result));
        }
    }
}
