int[] vetor1 = new int[10];
int[] vetor2 = new int[10];
int aux = 0;

Random random = new Random();

for (int referencia = 0; referencia < vetor2.Length -1; referencia++)
{
    for(int comparacao = referencia  + 1; comparacao < vetor2.Length; comparacao++)
    {
        if (vetor2[referencia] > vetor1[comparacao])
        {
            aux = vetor2[referencia];
            vetor2[referencia] = vetor2[comparacao];
            vetor2[comparacao] = aux;
        }

    }
}


//Array.Copy(vetor1, vetor2, vetor1.Length);
//Array.Sort(vetor2);

Console.WriteLine("Vetor1 (aleatório):");
Console.WriteLine(string.Join("\n", vetor1));
Console.WriteLine("\nVetor2 (ordenado):");
Console.WriteLine(string.Join("\n", vetor2));
