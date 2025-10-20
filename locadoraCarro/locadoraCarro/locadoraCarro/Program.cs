using System.ComponentModel;
using System.Runtime.CompilerServices;
using locadoraCarro.abstracts;
using locadoraCarro.Entities;
using locadoraCarro.Models;

RentalCompany rentalCompany = new RentalCompany();


List<string> mainOptions = new List<string>()
{
    "Menu Clientes",
    "Menu Veiculos",
    "Menu Locacoes",
    "Sair",
};

List<string> customersOptions = new List<string>()
{
    "Cadastrar Clientes",
    "Listar Cliente",
    "Editar Cliente",
    "Remover Cliente",
    "Voltar",
};

List<string> vehicleOptions = new List<string>()
{
    "Cadastrar Veiculos",
    "Listar Veiculos",
    "Editar Veiculos",
    "Remover Veiculos",
    "Voltar",
};

List<string> rentalOptions = new List<string>()
{
    "Cadastrar Locacao",
    "Listar Locacao",
    "Finalizar Locacao",
    "Remover Locacao",
    "Voltar",
};


void CreateCustomer()
{
    Console.WriteLine("Nome");
    string name = Console.ReadLine();
    Console.WriteLine("Data de nascimento");
    DateOnly bd = DateOnly.Parse(Console.ReadLine());
    Console.WriteLine("email");
    string email = Console.ReadLine();
    Console.WriteLine("rua");
    string street = Console.ReadLine();
    Console.WriteLine("numero");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine("complemento");
    string complment = Console.ReadLine();
    Console.WriteLine("bairro");
    string neighborhoad = Console.ReadLine();
    Console.WriteLine("cidade");
    string city = Console.ReadLine();
    Console.WriteLine("estado");
    string state = Console.ReadLine();
    Console.WriteLine("CEP");
    string zipCode = Console.ReadLine();

    var contact = new Contact(email, null);
    var address = new Address(street, number, complment, neighborhoad, city, state, zipCode, "Braizil");

    Console.WriteLine("Qual tipo de cliente está cadastrando (1 - PF | 2 - PJ)");
    int customerType = int.Parse(Console.ReadLine());

    if (customerType == 1)
    {
        Console.WriteLine("numero do cnh");
        string cnh = Console.ReadLine();
        Console.WriteLine("cpf");
        string cpf = Console.ReadLine();
        var customer = new PFCostumer(name, bd, email, contact, cnh, cpf);
        rentalCompany.Customers.Add(customer);
    }
}

void ListCustomers()
{
    Console.WriteLine("#### Customer List ####");
    foreach (var c in rentalCompany.Customers)
    {
        Console.WriteLine(c.ToString());
    }
}

Person FindCustomersByName(string n)
{
    return rentalCompany.Customers.Find(c => c.GetName() == n);
}

Person UpdatePhone()
{
    Console.WriteLine("Informe o nome do cliente a ser atualizado");
    string name = Console.ReadLine() ?? "";
    var customer = FindCustomersByName(name);
    if (customer is not null)
    {
        Console.WriteLine("Informe o telefone do cliente");
        string phone = Console.ReadLine();
        customer.setContactPhone(phone);
        Console.WriteLine("atualizado");
        return customer;
    }
    else
    {
        Console.WriteLine("cliente não encontrado");
        return null;
    }
}

void DeleteCustomer()
{
    Console.WriteLine("qual usuario");
    string name = Console.ReadLine() ?? "";
    var customer = FindCustomersByName(name);

    if (customer is not null)
    {
        rentalCompany.Customers.Remove(customer);
        Console.WriteLine("apagado");
    }
    else
    {
        Console.WriteLine("nem tem esse ai");
    }
}

void CustomerMenu(int op)
{
    switch (op)
    {

        case 1:
            {
                CreateCustomer();
                break;
            }
        case 2:
            {
                ListCustomers();
                break;
            }
        case 3:
            {
                Console.WriteLine(UpdatePhone();
                break;
            }
        case 4:
            {
                DeleteCustomer();
                break;
            }
    }
    do
    {

        int mainChoice = Menu.Display("###### Menu Principal ######", mainOptions);

        switch (mainChoice)
        {
            case 1:
                {
                    int customerChoice = Menu.Display("###### Menu Clientes ######", customersOptions);
                    break;
                }
            case 2:
                {
                    int vehicleChoice = Menu.Display("###### Menu Veiculo ######", vehicleOptions);
                    break;
                }
            case 3:
                {
                    int rentalChoice = Menu.Display("###### Menu Locacao ######", rentalOptions);
                    break;
                }
            case 4:
                {
                    Console.WriteLine("saindo");
                    break;
                }
            default:
                Console.WriteLine("tente de novo");
                break;
        }
        while (mainChoice != 4) ;
    }
    }
