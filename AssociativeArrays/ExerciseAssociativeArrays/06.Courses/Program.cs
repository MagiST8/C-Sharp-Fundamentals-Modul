using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
             .Split(':')
             .Select(s => s.Trim())
             .ToList();

            var Courses = new Dictionary<string, List<string>>();
            var studentNames = new List<string>();


            while (true)
            {
                var courseName = input[0];

                if (courseName == "end")
                {
                    break;
                }
                var studentName = input[1];

                if (!Courses.ContainsKey(courseName))
                {
                    Courses.Add(courseName, studentNames);
                    studentNames.Add(studentName);
                    studentNames = new List<string>();
                }
                else
                {
                    Courses[courseName].Add(studentName);
                }

                input = Console.ReadLine()
                .Split(':')
                .Select(s => s.Trim())
                .ToList();
            }

            foreach (var course in Courses)
                   
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count()}");

                     
                foreach (var name in course.Value)
                {
                    Console.WriteLine("-- {0}", name);
                }
            }
        }
    }
}
