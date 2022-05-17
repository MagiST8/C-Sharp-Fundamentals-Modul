using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double basse = double.Parse(Console.ReadLine());
            int power=int.Parse(Console.ReadLine());
            Console.WriteLine(GetMAthPower(basse,power));
        }
        static double GetMAthPower(double basse, int power)
        {
            return Math.Pow(basse, power);
        }
    }
}
