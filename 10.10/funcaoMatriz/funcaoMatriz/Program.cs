int linhas, colunas;

int[,] ConstruitMatriz(int lin, int col)
{
    return new int[lin, col];
}

int[,] PreencherMatriz(int[,] m, int l, int c) {
    for(int i = 0; i < l; i++)
    {
        for(int j = 0;  j < c; j++)
        {
            m[i, j] = Random.Shared.Next(1, 50);
        }
    }
    return m;
}

void ExibirMatriz(int[,]m, int l, int c){
    for(int i= 0; i<l; i++)
    {
        for( int j = 0; j < c; j++)
        {
            Console.Write($"[{m[i,j]}]");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("quantas linhas");
linhas = int.Parse(Console.ReadLine());

Console.WriteLine("quantas colunas");
colunas = int.Parse(Console.ReadLine());

var matriz = ConstruitMatriz(linhas, colunas);
matriz = PreencherMatriz(matriz, linhas, colunas);
ExibirMatriz(matriz, linhas, colunas);
