using System;
using System.Collections.Generic;
using System.Text;

namespace SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                int numberToProcess = i;
                int sum = 0;
                while (numberToProcess != 0)
                {
                    int currentDigit = numberToProcess % 10;
                    numberToProcess = numberToProcess / 10;
                    sum += currentDigit;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
