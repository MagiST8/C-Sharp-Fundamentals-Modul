using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.OrderByAge
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            List<string> command = Console.ReadLine().Split().ToList();
            List<Person> list = new List<Person>();

            while (command[0] != "End")
            {

                string name = command[0].ToString();
                string id = command[1].ToString();
                int age = int.Parse(command[2]);
                Person person = new Person( name, id, age );

                list.Add(person);
                command = Console.ReadLine().Split().ToList();

            }
            if (command[0] == "End")
            {
                var result = list.OrderBy(person => person.Age);
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
                }
            }
        }
    }

    }

