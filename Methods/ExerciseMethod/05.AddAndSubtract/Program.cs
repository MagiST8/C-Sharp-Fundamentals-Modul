using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2=int.Parse(Console.ReadLine());
            int num3=int.Parse(Console.ReadLine());
            Console.WriteLine(AddIntegers(num1,num2)-num3);
        }
        static int AddIntegers(int num1, int num2)
        {
            int sum = num1+num2;
            return sum;
            
        }
        
    }
}
