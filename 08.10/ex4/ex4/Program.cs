int number = 0;

Console.WriteLine("Insira um numero: ");
number = int.Parse(Console.ReadLine());

    Console.WriteLine($"Numeros pares de 1 ate {number}");
for(int i = 0; i != number; i++)
{
    if(i %  2 == 0)
    {
        Console.WriteLine(i);
    }
}