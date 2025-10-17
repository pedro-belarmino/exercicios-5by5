using queue;

Queue queue = new Queue();
int op;
Person h = null;
Person t = null;

do
{
    Console.WriteLine("\n\n\nMe fala ai o que você quer fazer com a sua fila meu querido meu querido.");
    Console.WriteLine("1 - Adicionar item na lista");
    Console.WriteLine("2 - Apagar item na lista");
    Console.WriteLine("3 - Exibir lista");
    Console.WriteLine("4 - Quitar");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            {
                Person aux = new Person();
                Console.WriteLine("coloca ai o que voce quer que seja adicionado");
                aux.setName(Console.ReadLine());
                queue.AddPerson(aux);
                break;
            }
        case 2:
            {
                queue.RemovePerson();
                break;
            }
        case 3:
            {
                queue.ShowQueue();
                Console.WriteLine("o tamanho da fila e " + queue.QueueSize());
                break;
            }
    }

} while (op != 4);

