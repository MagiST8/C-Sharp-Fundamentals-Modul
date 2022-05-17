using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] items=numbers.Split(); 
            int[] officalNum=new int[items.Length]; 
                             
            int sum = 0;
            foreach (int item in items)
            {
                if (item%2==0)
                {
                    sum += item;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
