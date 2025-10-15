int[,] matriz = new int[3, 5];

for (int linha = 0; linha < 3; linha++)
{
    for (int coluna  = 0; coluna < 3; coluna++)
    {
        Console.WriteLine($"informe o numeor em {linha}x{coluna}");
        matriz[linha, coluna] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("a lista aqui oh >>");

for (int linha = 0;linha < 3; linha++)
{
    for(int coluna = 0;coluna < 3; coluna++)
    {
        Console.Write($"[{matriz[linha, coluna]}]");
    }
Console.WriteLine();
} 