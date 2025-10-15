int number = 0;
int total = 0;

while(number >= 0)
{
    Console.WriteLine("Digite um numero inteiro, negativo ou positivo");
    number = int.Parse(Console.ReadLine());



    if(number < 0)
    {
        Console.WriteLine($"O total de todos os números positivos inseridos é {total}");
        return;
    }



    total += number;


}