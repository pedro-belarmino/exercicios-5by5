int[] oddNumber = new int[10];
int[] evenNumber = new int[10];
int number = 0;

for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Insira um numero");

    number = int.Parse(Console.ReadLine());

    if (number % 2 == 0)
    {
        oddNumber[i] = number;
    }
    else
    {
        evenNumber[i] = number;
    }
}


Console.WriteLine($"numeros pares: {String.Join(" ", oddNumber.Where(n => n != 0))}");
Console.WriteLine($"numeros impares {String.Join(" ", evenNumber.Where(n => n != 0))}");