using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AminerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> resoursec = new Dictionary<string, long>();

            string resurses = Console.ReadLine();
            while (resurses!="stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (resoursec.ContainsKey(resurses))//проверяваме дали ресурса дали вече съществува
                {
                    resoursec[resurses] += quantity;//ако вече го има,му добавяме новата стойност
                }
                else
                {
                    resoursec.Add(resurses, quantity);//ако го няма го добаваме
                }



                resurses = Console.ReadLine();

            }
            foreach (var item in resoursec)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
