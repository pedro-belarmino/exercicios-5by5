using System.Runtime.CompilerServices;
using filaPrioridade;

Queue queue = new Queue();
Queue priorityQueue = new Queue();
int op;
Person h = null;
Person t = null;
Bank bank = new Bank;

do
{
    Console.WriteLine("\nEscolha o que quer fazer");
    Console.WriteLine("1 - Enfileirar cliente");
    Console.WriteLine("2 - Atender cliente");
    Console.WriteLine("3 - Mostrar filas");
    Console.WriteLine("4 - Sair");

    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            {
                Console.WriteLine("Nome do cliente");
                string name = Console.ReadLine();
                Console.WriteLine("Idade do cliente");
                int age = int.Parse(Console.ReadLine());

                Person c = new(name, age);

                if (c.Priority)
                {
                    bank.PriorityQueue.pushQueue(c);
                } else
                {
                    bank.NomalQueue.pushQueue(c);
                }
                    break;
                
            }
        case 2:
            {
                c = bank.GetClient();
                Console.WriteLine(c.ToString());
                break;
            }
    }

} while (op  != 4);