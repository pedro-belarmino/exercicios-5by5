using System;
using System.IO;
using Bookshelf;

class Program
{
    static void Main()
    {
        string directory = "C:\\Projects\\Files";
        string file = "books.txt";
        string fullPath = Path.Combine(directory, file);

        Shelf shelf = new Shelf(fullPath);
        int op;

        do
        {
            Console.WriteLine("\n#### Escolha uma opcaoo ####");
            Console.WriteLine("1 Adicionar Livro");
            Console.WriteLine("2 Listar Livros");
            Console.WriteLine("3 Editar Livro");
            Console.WriteLine("4 Remover Livro");
            Console.WriteLine("5 Sair");
            Console.WriteLine("############################");

            if (!int.TryParse(Console.ReadLine(), out op)) op = 0;

            switch (op)
            {
                case 1:
                    Console.Write("Titulo: ");
                    string title = Console.ReadLine();
                    Console.Write("Autor: ");
                    string author = Console.ReadLine();
                    Console.Write("Categoria: ");
                    string category = Console.ReadLine();

                    shelf.AddBook(new Book(title, author, category));
                    break;

                case 2:
                    shelf.ListBooks();
                    break;

                case 3:
                    Console.Write("Digite o titulo do livro a editar: ");
                    string editTitle = Console.ReadLine();
                    shelf.EditBook(editTitle);
                    break;

                case 4:
                    Console.Write("Digite o titulo do livro a remover: ");
                    string removeTitle = Console.ReadLine();
                    shelf.RemoveBook(removeTitle);
                    break;

                case 5:
                    Console.WriteLine("Encerrando...");
                    break;

                default:
                    break;
            }

        } while (op != 5);
    }
}
