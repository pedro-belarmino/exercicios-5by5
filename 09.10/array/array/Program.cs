int i = 0, lngth = 0;

Console.WriteLine("Digite o tamanho do vetor");
lngth = int.Parse(Console.ReadLine());

int[] numbers = new int[lngth];

while (i < lngth) {
    numbers[i] = Random.Shared.Next(1, 100);
    i++
}

for(i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i] + " ");
}
