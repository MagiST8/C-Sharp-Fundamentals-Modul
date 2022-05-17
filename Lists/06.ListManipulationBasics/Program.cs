using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] token = command.Split();//елементи на командата
                string action = token[0];
                if (action == "Add")
                {
                    int numberToAdd = int.Parse(token[1]);
                    numbers.Add(numberToAdd);//добавя се числото към листа
                }
                else if (action == "Remove")
                {
                    int numberToRemove = int.Parse(token[1]);
                    numbers.Remove(numberToRemove);
                }
                else if (action == "RemoveAt")
                {
                    int numberToRemoveAt = int.Parse(token[1]);
                    numbers.RemoveAt(numberToRemoveAt);
                }
                else if (action == "Insert")
                {
                    int indexToInsert = int.Parse(token[2]);
                    int elementToInsert = int.Parse(token[1]);
                    numbers.Insert(indexToInsert,elementToInsert);
                }
                command = Console.ReadLine();

            }
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
