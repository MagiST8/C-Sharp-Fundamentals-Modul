using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guest = new List<string>();//ползва се са да добавяме имената, които ще идват на партито и ще изваждаме имената,които няма да идват
            int n = int.Parse(Console.ReadLine());//прочитаме колко команди ще ни се дадът
            for (int i = 0; i < n; i++)//въртим цикъл с боря на командите
            {
                string[] cmdArgs = Console.ReadLine().Split().ToArray();//прочитаме командата 
                string name=cmdArgs[0];
                if (cmdArgs.Length==3)
                {
                    if (guest.Contains(name))//проверявам дали името го има в листа
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;//отива на следващата команда
                    }
                    guest.Add(name);//ако го няма в листа, го добавяме
                }
                else if (cmdArgs.Length==4)
                {
                    if (!guest.Contains(name))//проверяваме дали го няма името в листа
                    {
                        Console.WriteLine($"{name} is not in the list!");//казваме, че го няма в листа
                        continue;
                    }
                    guest.Remove(name);//премахваме името ако вече съ съдържа в листа
                }

            }
            PrintGuest(guest);
        }
        static void PrintGuest(List<string> guest)//създаваме медот за да принтираме всички гости в листа
        {
            for (int i = 0; i < guest.Count; i++)
            {
                Console.WriteLine(guest[i]);
            }
        }
    }
}
