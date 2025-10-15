using ex1;

Pessoa[] pessoas = new Pessoa[3];

Console.WriteLine("Nome da primeira pessoa");
pessoas[0].setNome(Console.ReadLine());

Console.WriteLine("Sobrenome da primeira pessoa");4
pessoas[0].setSobrenome(Console.ReadLine());

Console.WriteLine("Idade da primeira pessoa");
pessoas[0].setIdade(int.Parse(Console.ReadLine()));

Console.WriteLine("Altura da primeira pessoa");
pessoas[0].setAltura(double.Parse(Console.ReadLine()));

Console.WriteLine("Sexo da primeira pessoa");
pessoas[0].setSexo(Console.ReadLine());

pessoas[1].setNome("pessoa 2");
pessoas[1].setSobrenome("sobrenome 2");
pessoas[1].setIdade(20);
pessoas[1].setAltura(1.80);
pessoas[1].setSexo("Masculino");

pessoas[2].setNome("pessoa 3");
pessoas[2].setSobrenome("sobrenome 3");
pessoas[2].setIdade(20);
pessoas[2].setAltura(1.80);
pessoas[2].setSexo("Masculino");


for (int i = 0; i < pessoas.Length; i++)
{
    pessoas[i].showPessoas();
}