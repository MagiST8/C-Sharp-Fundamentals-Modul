using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Students2._0
{
    class Student
    {
        public Student(string firstName,string lastName,int age,string hometown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Hometown = hometown;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] splitParams = command.Split(' ');
                string firstName = splitParams[0];
                string lastName = splitParams[1];
                int age = int.Parse(splitParams[2]);
                string hometown = splitParams[3];
                bool doesStudentExist = DoesStudentExist(students,firstName, lastName);
                if (doesStudentExist)
                {
                    Student existingStudents = GetExistingStudent(students, firstName, lastName);
                    existingStudents.FirstName = firstName;
                    existingStudents.LastName = lastName;
                    existingStudents.Age = age;
                    existingStudents.Hometown = hometown;
                }
                else
                {
                    Student newStudent = new Student(firstName, lastName, age, hometown);

                    students.Add(newStudent);
                }
               

                command = Console.ReadLine();

            }
            string hometownToSearch = Console.ReadLine();
            List<Student> filteredStudens = students.FindAll(student => student.Hometown == hometownToSearch);
            foreach (Student student in filteredStudens)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        private static Student GetExistingStudent(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName==firstName&&student.LastName==lastName)
                {
                    return student;
                }
            }
            return null;
        }

        static bool DoesStudentExist(List<Student> students, string firstName,string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName==firstName && student.LastName==lastName)
                {
                    return true;
                }
                
            }
            return false;


        }
    }
}
