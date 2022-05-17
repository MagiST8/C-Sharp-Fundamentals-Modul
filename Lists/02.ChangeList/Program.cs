using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command!="end")
            {
                string[] token = command.Split();
                if (token[0]=="Delete")
                {
                    int delete=int.Parse(token[1]);
                    numbers.RemoveAll(x => x == delete);
                }
                else if (token[0]=="Insert")
                {
                    int element = int.Parse(token[2]);
                    int position=int.Parse(token[1]);
                    numbers.Insert(element,position);
                }
                command = Console.ReadLine();

            }
            Console.WriteLine(String.Join(" ", numbers));
        }
        }
    }
