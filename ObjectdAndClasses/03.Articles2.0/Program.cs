using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Articles
{
    class Artical
    {
        public Artical(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} -{Content}:{Author}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int countCommands = int.Parse(Console.ReadLine());
            List<Artical> articles = new List<Artical>();

            for (int i = 0; i < countCommands; i++)
            {
                string[] splittedCommand = Console.ReadLine()
                    .Split(',');

                string title = splittedCommand[0];
                string content = splittedCommand[1];
                string author = splittedCommand[2];

                var article = new Artical(title, content, author);

                articles.Add(article);
            }
            string orderBy = Console.ReadLine();

            string orderByWhat = Console.ReadLine();

            switch (orderByWhat)
            {
                case "title":
                    articles = articles.OrderBy(X => X.Title).ToList();
                    break;

                case "content":
                    articles = articles.OrderBy(X => X.Content).ToList();
                    break;

                case "autor":
                    articles = articles.OrderBy(X => X.Author).ToList();
                    break;
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }

    }

}



