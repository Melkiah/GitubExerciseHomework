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

        public Book(string title, string publisher, DateTime releaseDate, string ISBN, decimal price)
        {
            this.Title = title;
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

        public Library(String name)
        {
            this.Name = name;
            this.Books = new List<Book>();
        }

        public decimal GetBooksValue()
        {
            decimal sum = 0;
            foreach (var item in this.Books)
            {
                sum += item.Price;
            }

            return sum;
        }
    }

    class BookLibrary
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Library> library = new List<Library>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                Book book = new Book(
                input[0],
                input[2],
                DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                input[4],
                decimal.Parse(input[5]));

                if (!ContainsAuthor(library, input[1]))
                {
                    Library newLibrary = new Library(input[1]);
                    newLibrary.Books.Add(book);
                    library.Add(newLibrary);
                }
                else
                {
                    foreach (var item in library)
                    {
                        if (item.Name == input[1])
                        {
                            item.Books.Add(book);
                        }
                    }
                }
            }

            var list  = library.OrderByDescending(x => x.GetBooksValue()).ThenBy(x =>x.Name);

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} -> {item.GetBooksValue():F2}");
            }
            
        }

        public static bool ContainsAuthor(List<Library> library, string v)
        {
            foreach (var item in library)
            {
                if (item.Name == v)
                {
                    return true;
                }
            }
            return false;
        }
    }
}