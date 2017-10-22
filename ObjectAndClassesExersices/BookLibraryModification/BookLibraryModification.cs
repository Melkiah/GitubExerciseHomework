using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryModification
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

    //class Library
    //{
    //    public string Name { get; set; }
    //    public List<Book> Books { get; set; }

    //    public Library(String name)
    //    {
    //        this.Name = name;
    //        this.Books = new List<Book>();
    //    }

    //    public decimal GetBooksValue()
    //    {
    //        decimal sum = 0;
    //        foreach (var item in this.Books)
    //        {
    //            sum += item.Price;
    //        }

    //        return sum;
    //    }
    //}
    class BookLibraryModification
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Book> library = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                Book book = new Book(
                input[0],
                input[2],
                DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                input[4],
                decimal.Parse(input[5]));

                library.Add(book);
            }

            DateTime timeline = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            List<Book> list = library.Where(x=> x.ReleaseDate > timeline).ToList();

            foreach (var item in list.OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title))
            {
                Console.WriteLine($"{item.Title} ->{item.ReleaseDate: dd.MM.yyyy}");
            }           
            

        }
    }
}
