int number = 0;
while (number < 1 || number > 10)
{
Console.WriteLine("Insita um numero inteiro entre 1 e 10");
number = int.Parse(Console.ReadLine());
}

for(int i = 1; i != 10; i++)
{
    Console.WriteLine($"{i} x {number} = {i * number} \n");
}