int choosedNumber = 0;
int trys = 0;

Random random = new Random();
int randomNumber = random.Next(1, 51);

Console.WriteLine("Advinhe o número misterioso");
do
{
choosedNumber = int.Parse(Console.ReadLine());

    trys++;
    
    if(choosedNumber == randomNumber)
    {
        Console.WriteLine("ACERTOOOOU MEU AMIGO");
        Console.WriteLine($"Você conseguiu acertar em {trys} tentativas");
        return;
    } else
    {
        Console.WriteLine("Errou amigo, tenta de novo ai.. :|");
    }


} while (choosedNumber != randomNumber);