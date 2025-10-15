int option = 0;
int number1 = 0;
int number2 = 0;
int total = 0;

while(option != 4)
{
    Console.WriteLine("Escolha uma opção");
    Console.WriteLine("Opção 1 - Soma");
    Console.WriteLine("Opção 2 - Subtracao");
    Console.WriteLine("Opção 3 - Multiplicacao");
    Console.WriteLine("Opção 4 - Sair");
    
    option = int.Parse(Console.ReadLine());

    if(option < 1 || option > 4)
    {
        Console.WriteLine("Opcao invalida, tente de novo");
    } else
    {
        Console.WriteLine("Insira o primeiro numero");
        number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira o segundo numero");
        number2 = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            total = number1 + number2;
            break;
        case 2:
            total = number1 - number2;
            break;
        case 3:
            total = number1 / number2;
            break;
    }
    Console.WriteLine($"O total da operacao e: {total} \n \n");
        return;
    }
}



