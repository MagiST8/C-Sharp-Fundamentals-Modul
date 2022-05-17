using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> passengers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capatyWagon = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {

                string[] token = command.Split();//елементи на командата

                if (token[0] == "Add")
                {
                    passengers.Add(int.Parse(token[1]));
                }

                else
                {
                    int numberOfPassengers = int.Parse(token[0]);
                    for (int i = 0; i < passengers.Count; i++)
                    {
                        if (passengers[i] + numberOfPassengers <= capatyWagon)
                        {
                            passengers[i] += numberOfPassengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", passengers));
        }

    }
}
