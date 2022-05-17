using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();//четем име на студента
                double grade = double.Parse(Console.ReadLine());//четем оценката
                if (!students.ContainsKey(studentName))//проверяваме дали го има,ако го няма го добаваме
                {
                    students.Add(studentName, new List<double>());//добавяме студента с оценката
                }
                students[studentName].Add(grade);//на всеки нов студент добавяме новата оценка

                
            }
            foreach (var item in students)
            {
                if (item.Value.Average() >= 4.50) //проверяваме дали оценката е >= от 4,50
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
                }
               
            }
        }
    }
}
