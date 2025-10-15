using ex2;
using Microsoft.VisualBasic;

Employee[] employees;

Console.Write("Insira quantos funcionarios cadastrar: ");
int numebrOfEmployees = int.Parse(Console.ReadLine());

employees = new Employee[numebrOfEmployees];

for (int i = 0; i < numebrOfEmployees; i++)
{
    string employeeName;
    int employeeType;
    int CLTemployeeSalary;
    int CLTBonus;
    

    Console.Write("Informe o nome do funcinario");
    employeeName = Console.ReadLine();
    do
    {
        Console.WriteLine("Insira a categoria do funcionairo (1 - CLT | 2 - PJ)");
        employeeType = int.Parse(Console.ReadLine());
    } while (employeeType != 1 && employeeType != 2);

    if(employeeType == 1)
    {
        Console.Write("Informe o salario do funcionario: ");
        CLTemployeeSalary = int.Parse(Console.ReadLine());

        Console.Write("\nInforme o bonus do funcionario:");
        CLTBonus = int.Parse(Console.ReadLine());
    }
}