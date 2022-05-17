using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopNumber(n);

        }
        static void PrintTopNumber(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (HasOddNuumber(i) && IsDigitSumDiviseBy8(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool HasOddNuumber(int n)
        {
            while (n > 0)
            {
                if ((n % 10) % 2 == 1)
                {
                    return true;
                    n /= 10;
                }
            }
            return false;
        }
        static bool IsDigitSumDiviseBy8(int n)
        {
            int digitSum = 0;
            while (n>0)
            {
                digitSum += n % 10;
                n /= 10;
            }
            if (digitSum%8==0)
            {
                return true;
            }
            return false;
        
        }
    }
}
