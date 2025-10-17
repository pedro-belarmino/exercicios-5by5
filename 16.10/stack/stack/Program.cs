using stack;

ClotingStack clothingStack = new ClotingStack();

int op = 0;

do
{
    Console.WriteLine("\n\n-----------------------------------------");
    Console.WriteLine("Opcoes:");
    Console.WriteLine("1 - adicionar item na pilha:");
    Console.WriteLine("2 - remover ultimo item da pilha:");
    Console.WriteLine("3 - exibir pilha:");
    Console.WriteLine("4 - sair e ir embora pra casa e ser feliz:");
    Console.WriteLine("-----------------------------------------\n\n");


    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            {

                Console.WriteLine("Nome da roupa");
                string name = Console.ReadLine();
                Console.WriteLine("Descricao da roupa");
                string description = Console.ReadLine();

                Clothing c = new Clothing(name, description);
                clothingStack.AddStack(c);
                
                break;
            }
        case 2:
            {
                clothingStack.RemoveStack();
                break;
            }
        case 3:
            {
                clothingStack.ShowStack();
                break;
            }
    }


} while (op != 4);