using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            GetFirstSumOFFactorialDivision(num1);
            GetSecondSumOfFactorialDivision(num2);
            Console.WriteLine($"{FinalSumOfFactorial(num1,num2):f2}");
        }
        static double GetFirstSumOFFactorialDivision(double num1)
        {
            double factorialFirstSum = 0;
            double currentFactorial = 1;
            if (num1>=1)
            {
                for (double i = num1; i>=1; i--)
                {
                    factorialFirstSum = i;
                    currentFactorial = factorialFirstSum * currentFactorial;
                }
            }
            return currentFactorial;

        }
        static double GetSecondSumOfFactorialDivision(double num2)
        {
            double factorialSecondSum = 0;
            double currentFactorila = 1;
            if (num2>=1)
            {
                for (double i = num2; i >= 1; i--)
                {
                    factorialSecondSum = i;
                    currentFactorila = factorialSecondSum * currentFactorila;
                }
            }
            return currentFactorila;
           
           
        }
        static double FinalSumOfFactorial(double num1, double num2)
        {
            double finalSum = GetFirstSumOFFactorialDivision(num1) / GetSecondSumOfFactorialDivision(num2);
            return finalSum;
        }
    }
}
