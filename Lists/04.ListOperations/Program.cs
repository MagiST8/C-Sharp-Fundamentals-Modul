using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command;
            //List<int> saveNumbers=new List<int>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command.Split().ToArray();//разделяме командите по спейсове//вземаме само индексите за това ползваме масиви
                if (cmdArg[0] == "Add") //cmdArg[0]- командата стои на нулева позиция, за това пишем [0]
                {
                    int givenNumber = int.Parse(cmdArg[1]);//вземаме даденото число и фо поставяме на 1ва позиция [1];
                    numbers.Add(givenNumber);//добавяме го в листа
                }
                else if (cmdArg[0] == "Insert")
                {
                    int insertNumber = int.Parse(cmdArg[1]);
                    int insertIndex = int.Parse(cmdArg[2]);

                    if (insertIndex >= 0 && insertIndex < numbers.Count)//проверяваме дали индекса е валиден, ако не е "cw invalid index"
                    {
                       numbers.Insert(insertIndex,insertNumber);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    
                                       
                }
                else if (cmdArg[0] == "Remove")
                {
                    int remove = int.Parse(cmdArg[1]);
                    if (remove >= 0 && remove < numbers.Count)
                    {
                        numbers.RemoveAt(remove);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (cmdArg[0] == "Shift")
                {
                    string direction = cmdArg[1];
                    int count = int.Parse(cmdArg[2]);

                    if (direction == "left")
                    {
                        ShiftLeft(numbers, count);
                    }
                    else if (direction == "right")
                    {
                        ShiftRight(numbers, count);
                    }
                }

            }
            Console.WriteLine(String.Join(" ", numbers));

        }
        static void ShiftLeft(List<int> number, int count)
        {
            int realCount = count % number.Count;//изчисляване колко на брой пъти ще се завърти листа
            for (int i = 1; i <= realCount; i++)
            {
                int firstElement = number[0];//вземаме първият елемент за да не загубим стойността му
                number.Remove(firstElement); //премахваме първият елемент
                number.Add(firstElement);//добавяме първият елемент накрая в листа
            }

        }
        static void ShiftRight(List<int> numbers, int count)
        {
            int realCount = count % numbers.Count;//изчисляване колко на брой пъти ще се завърти листа
            for (int i = 1; i <= realCount; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNumber);   //слагаме на нулева позиция последният елемент
            }
        }
        
    }
}
