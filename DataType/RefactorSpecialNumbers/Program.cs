using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double sum = 0;
            int number = 0;
            bool isSpecialNumber = false;
            for (int i = 1; i <= num; i++)
            {
                number = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", number, isSpecialNumber);
                sum = 0;
                i = number;
            }

        }
    }
}
