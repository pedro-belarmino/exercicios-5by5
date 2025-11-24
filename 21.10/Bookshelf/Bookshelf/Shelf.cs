using System;
using System.Collections.Generic;
using System.IO;

namespace Bookshelf
{
    internal class Shelf
    {
        private string filePath;

        public Shelf(string path)
        {
            filePath = path;
            if (!File.Exists(filePath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);
                File.Create(filePath).Close();
            }
        }

        public void AddBook(Book book)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(book.ToString());
            }
            Console.WriteLine("Livro adicionado com sucesso");
        }

        public List<Book> ReadBooks()
        {
            List<Book> books = new List<Book>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var parts = line.Split(';');
                    if (parts.Length == 3)
                    {
                        books.Add(new Book(parts[0], parts[1], parts[2]));
                    }
                }
            }
            return books;
        }

        public void ListBooks()
        {
            var books = ReadBooks();
            if (books.Count == 0)
            {
                Console.WriteLine("Nenhum livro encontrado");
                return;
            }

            foreach (var book in books)
            {
                Console.WriteLine(book.Display());
            }
        }

        public void EditBook(string title)
        {
            var books = ReadBooks();
            var book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (book == null)
            {
                Console.WriteLine("Livro não encontrado.");
                return;
            }

            Console.Write("Novo título (ou enter para manter): ");
            string newTitle = Console.ReadLine();
            Console.Write("Novo autor (ou enter para manter): ");
            string newAuthor = Console.ReadLine();
            Console.Write("Nova categoria (ou enter para manter): ");
            string newCategory = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(newTitle)) book.Title = newTitle;
            if (!string.IsNullOrWhiteSpace(newAuthor)) book.Author = newAuthor;
            if (!string.IsNullOrWhiteSpace(newCategory)) book.Category = newCategory;

            SaveAll(books);
            Console.WriteLine("Livro editado com sucesso");
        }

        public void RemoveBook(string title)
        {
            var books = ReadBooks();
            var book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (book == null)
            {
                Console.WriteLine("Livro não encontrado");
                return;
            }

            books.Remove(book);
            SaveAll(books);
            Console.WriteLine("Livro removido");
        }

        private void SaveAll(List<Book> books)
        {
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                foreach (var b in books)
                {
                    sw.WriteLine(b.ToString());
                }
            }
        }
    }
}
