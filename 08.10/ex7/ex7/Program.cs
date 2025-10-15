int number = 0;
int previousNumber = 0;


while(number <= 0)
{

    Console.WriteLine("Insira um numero maior que 0");
    number = int.Parse(Console.ReadLine());

        if(number <= 0)
        {
            Console.WriteLine("O que eu acabei de falar?");
        }

}
Console.WriteLine("\n");
for(int i = 0; i < 10; i++)
{
    Console.WriteLine(number);
    number += previousNumber;
    previousNumber = number;
}