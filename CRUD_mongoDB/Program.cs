// See https://aka.ms/new-console-template for more information
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

await RunAsync();

async Task RunAsync()
{
    var client = new MongoClient("mongodb+srv://pedrogbelarmino_db_user:6GrlZ0Niylv3X47Q@cluster0.sopwtrl.mongodb.net/");

    var database = client.GetDatabase("CRUDLivros");
    var collectionAuthor = database.GetCollection<Author>("Authors");
    var collectionBook = database.GetCollection<Book>("Books");


    async Task CreateAuthor(IMongoCollection<Author> collectionAuthor)
    {
        List<Author> authors = new List<Author>();

        Console.WriteLine("quantos autores quer inserir?");
        int quantity = int.Parse(Console.ReadLine());
        for (int i = 0; i < quantity; i++)
        {
            Console.WriteLine($"\n Insira o {i + 1} autor:");
            string name = Console.ReadLine();

            Console.WriteLine($"\n Insira o país do autor:");
            string country = Console.ReadLine();

            authors.Add(new Author(name, country));
        }

        await collectionAuthor.InsertManyAsync(authors);
        Console.WriteLine("\nAutor adicionado!\n");
    }

    async Task<List<Author>> GetAuthors(IMongoCollection<Author> collectionAuthor)
    {
        return await collectionAuthor.Find(_ => true).ToListAsync();
    }


    async Task UpdateAuthorName(IMongoCollection<Author> collectionAuthor)
    {
        Console.WriteLine("Insira o ID do autor que quer atualizar: ");
        string authorId = Console.ReadLine();

        var id = ObjectId.Parse(authorId);

        Console.WriteLine("Insira o novo nove do autor: ");
        string newName = Console.ReadLine();

        await collectionAuthor.UpdateOneAsync(
            a => a.Id == authorId,
            Builders<Author>.Update.Set(a => a.Name, newName)
        );
        Console.WriteLine("Autor atualizado!");
    }

    async Task DeleteAuthor(IMongoCollection<Author> collectionAuthor)
    {
        Console.WriteLine("Insira o Id do autor que quer deletar: ");
        string authorId = Console.ReadLine();
        var id = ObjectId.Parse(authorId);

        await collectionAuthor.DeleteOneAsync(
            a => a.Id == authorId
        );
        Console.WriteLine("autor deletado!");
    }


    async Task CreateBook(IMongoCollection<Book> collectionBook)
    {
        List<Book> books = new List<Book>();

        Console.WriteLine("quantos livros quer inserir?");
        int quantity = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantity; i++)
        {
            Console.WriteLine($"Insira o {i + 1} livro: ");
            string title = Console.ReadLine();

            Console.WriteLine($"Insira o id do autor do livro: ");
            string authorId = Console.ReadLine();

            Console.WriteLine("Insira o ano do livro: ");
            int year = int.Parse(Console.ReadLine());

            books.Add(new Book(title, authorId, year));
        }
        await collectionBook.InsertManyAsync(books);
        Console.WriteLine("\n Livro Adicionado!\n");
    }

    async Task<List<Book>> GetBooks(IMongoCollection<Book> collectionBook)
    {
        return await collectionBook.Find(_ => true).ToListAsync();
    }


    async Task UpdateBookTitle(IMongoCollection<Book> collectionBook)
    {
        Console.WriteLine("Insira o id do livro que quer atualizar o titulo: ");
        string bookId = Console.ReadLine();

        var id = ObjectId.Parse(bookId);

        Console.WriteLine("Insira o novo título: ");
        string newTitle = Console.ReadLine();

        await collectionBook.UpdateOneAsync(
            a => a.Id == bookId,
            Builders<Book>.Update.Set(a => a.Title, newTitle)
        );
        Console.WriteLine("livro atualizado!");
    }

    async Task DeleteBook(IMongoCollection<Book> collectionBook)
    {
        Console.WriteLine("Insira o id do livro que quer deletar: ");
        string bookId = Console.ReadLine();
        var id = ObjectId.Parse(bookId);

        await collectionBook.DeleteOneAsync(
            a => a.Id == bookId
        );
        Console.WriteLine("Livro deletado!");
    }

    //--------------------------------------------Switch------------------------------------------------
    int optionAuthor;
    do
    {
        Console.WriteLine("----menu de autores----\n");
        Console.WriteLine("Enter an option:");
        Console.WriteLine("1. inserir autor");
        Console.WriteLine("2. listar autores");
        Console.WriteLine("3. atualizar nome do autor");
        Console.WriteLine("4. deletar autor");
        Console.WriteLine("5. sair");

        optionAuthor = int.Parse(Console.ReadLine());
        switch (optionAuthor)
        {
            case 1:
                await CreateAuthor(collectionAuthor);
                break;
            case 2:
                var authors = await GetAuthors(collectionAuthor);
                Console.WriteLine("\n----lista de autores----\n");
                foreach (var a in authors)
                {
                    Console.WriteLine(a.ToString());
                }
                Console.WriteLine("-------------------");
                break;
            case 3:
                await UpdateAuthorName(collectionAuthor);
                break;
            case 4:
                await DeleteAuthor(collectionAuthor);
                break;
            case 5:
                Console.WriteLine("saindo...");
                break;
            default:
                Console.WriteLine("opcao invalida, tente de novo");
                break;
        }
    } while (optionAuthor != 5);

    int optionBook;
    do
    {
        Console.WriteLine("\n----menu de livros----\n");
        Console.WriteLine("selecione uma opcao:");
        Console.WriteLine("1. adicionar livro");
        Console.WriteLine("2. listar libros");
        Console.WriteLine("3. atualizar titulo de livro");
        Console.WriteLine("4. deletar livro");
        Console.WriteLine("5. sair");

        optionBook = int.Parse(Console.ReadLine());
        switch (optionBook)
        {
            case 1:
                await CreateBook(collectionBook);
                break;
            case 2:
                var books = await GetBooks(collectionBook);
                Console.WriteLine("\n----lista de livros----\n");
                foreach (var b in books)
                {
                    Console.WriteLine(b.ToString());
                }
                Console.WriteLine("-------------------");
                break;
            case 3:
                await UpdateBookTitle(collectionBook);
                break;
            case 4:
                await DeleteBook(collectionBook);
                break;
            case 5:
                Console.WriteLine("saindo...");
                break;
            default:
                Console.WriteLine("opcao invalida, tente de novo");
                break;
        }
    } while (optionBook != 5);
}


