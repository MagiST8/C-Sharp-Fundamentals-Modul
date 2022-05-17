using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CammonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split().ToArray();
            string[] arr2 = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j] && arr1[i] != null && arr2[j]!= null)
                    {
                        Console.Write(arr1[i] + " ");
                        arr1[i] = null;
                        arr2[j] = null;

            }
        }
    }
}
    }
}
