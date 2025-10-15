using System.ComponentModel.DataAnnotations.Schema;
using ex4;

ContaBancaria conta = new ContaBancaria();
Console.WriteLine("Nome do titular da conta");
conta.setTitular(Console.ReadLine());


void Menu(string option)
{
    Console.WriteLine("Escolha uma opcao");
    Console.WriteLine("1 - Depositar");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Sair");


    switch (option)
    {
        case "1":
            Console.WriteLine("Insira o tanto que quer depositar");
            conta.setSaldo(double.Parse(Console.ReadLine()));
            break;

        case "2":
            double value;
            Console.WriteLine("Insira o tanto que quer sacar");
            value = double.Parse(Console.ReadLine());
            conta.Sacar(value);
            break;
    }
}

