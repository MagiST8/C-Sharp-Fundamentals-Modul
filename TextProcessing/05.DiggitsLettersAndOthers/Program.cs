using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DiggitsLettersAndOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder letters=new StringBuilder();
            StringBuilder digits=new StringBuilder();
            StringBuilder other=new StringBuilder();

            string text = Console.ReadLine();

            foreach (char item in text)
            {
                if (char.IsLetter(item))
                {
                    letters.Append(item);
                }
                else if (char.IsDigit(item))
                {
                    digits.Append(item);
                }
                else
                {
                    other.Append(item);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
