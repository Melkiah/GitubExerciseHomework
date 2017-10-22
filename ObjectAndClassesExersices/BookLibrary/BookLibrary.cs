using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        public Book(string title, string autor, string publisher, DateTime releaseDate, string ISBN, decimal price)
        {
            this.Title = title;
            this.Author = autor;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.ISBN = ISBN;
            this.Price = price;
        }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }


    }

    class BookLibrary
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Book> bookList = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                Book book = new Book(
                input[0],
                input[1],
                input[2],
                DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                input[4],
                decimal.Parse(input[5]));
                bookList.Add(book);
            }

            var list = bookList.GroupBy(book => book.Author)
                .Select(l => new
                {
                    Author = l.Key,
                    Price = l.Sum(p => p.Price)
                })
                .OrderByDescending(p => p.Price)
                .ThenBy(a => a.Author).ToList();

            foreach (var item in list)
            {
                Console.WriteLine("{0} -> {1}", item.Author, item.Price);
            }
        }
    }
}