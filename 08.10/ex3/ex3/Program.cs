int number = 0;


do
{
    Console.WriteLine("Insira um numero inteiro positivo");
    number = int.Parse(Console.ReadLine());
    if (number <= 0)
    {
        Console.WriteLine("eu falei um numero positivo");
    } else
    {
            Console.WriteLine("Contagem Regressiva");
        for(int i = number; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }
} while (number <= 0);