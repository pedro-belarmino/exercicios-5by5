using System;

namespace Bookshelf
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }

        public Book(string t, string a, string c)
        {
            Title = t;
            Author = a;
            Category = c;
        }

        public override string ToString()
        {
            return $"{Title};{Author};{Category}";
        }

        public string Display()
        {
            return $"Título: {Title}\nAutor: {Author}\nCategoria: {Category}\n";
        }
    }
}
