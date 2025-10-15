
Console.WriteLine("Qual funcao vai ser executada? \n" +
    "1- Cálculo de média e aprovação, \n" +
    "2 - Verificação de número par ou ímpar, \n" +
    "3 - Maior de dois números, \n" +
    "4 - Cálculo de IMC (Índice de Massa Corporal), \n" +
    "5 - Verificação de múltiplos, \n" +
    "6 - Cálculo de desconto em produto, \n" +
    "7 - Classificação de triângulo, \n" +
    "8 - Cálculo de média ponderada e conceito \n");
int funcao = int.Parse(Console.ReadLine());


if (funcao == 1)
{

    //1
    Console.WriteLine("Insira a primeira nota");
    float nota1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Insira a segunda nota");
    float nota2 = float.Parse(Console.ReadLine());
    Console.WriteLine("Insira a terceira nota");
    float nota3 = float.Parse(Console.ReadLine());

    float media = (nota1 + nota2 + nota3) / 3;

    if (media >= 7)
    {
        Console.WriteLine($"Aprovado ({media})");
    }
    else
    {
        Console.WriteLine($"Reprovado ({media})");
    }

}
else if (funcao == 2)
{

    //2
    Console.WriteLine("Insira um numero");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine("Par");
    }
    else
    {
        Console.WriteLine("Impar");
    }

}
else if (funcao == 3)
{
    //3
    Console.WriteLine("Insira um numero");
    int numero1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira outro numero");
    int numero2 = int.Parse(Console.ReadLine());

    if (numero1 > numero2)
    {
        Console.WriteLine("O maior numero é: " + numero1);
    }
    else if (numero2 > numero1)
    {
        Console.WriteLine("O maior numero é: " + numero2);
    }
    else
    {
        Console.WriteLine("Os numeros são iguais");
    }

}
else if (funcao == 4)
{


    //4
    Console.WriteLine("Insira seu peso");
    float peso = float.Parse(Console.ReadLine());
    Console.WriteLine("Insira sua altura em cm");
    float altura = float.Parse(Console.ReadLine()) / 100;

    float imc = peso / (altura * altura);

    if (imc < 18.5)
    {
        Console.WriteLine("Abaixo do peso");
    }
    else if (imc >= 18.5 && imc <= 24.9)
    {
        Console.WriteLine("Peso normal");
    }
    else if (imc >= 25 && imc <= 29.9)
    {
        Console.WriteLine("Sobrepeso");
    }
    else if (imc >= 30)
    {
        Console.WriteLine("Obesidade");
    }

}

else if (funcao == 5)
{


    //5
    Console.WriteLine("Insira um numero inteiro");
    int Numero1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira outro numero inteiro");
    int Numero2 = int.Parse(Console.ReadLine());

    if (Numero1 % Numero2 == 0)
    {
        Console.WriteLine(Numero1 + " é divisível por " + Numero2);
    }
    else
    {
        Console.WriteLine(Numero1 + " não é divisível por " + Numero2);
    }

    if (Numero2 % Numero1 == 0)
    {
        Console.WriteLine(Numero2 + " é divisível por " + Numero1);
    }
    else
    {
        Console.WriteLine(Numero2 + " não é divisível por " + Numero1);
    }

}
else if (funcao == 6)
{

    //6
    Console.WriteLine("Insira o valor do produto");
    float valor = float.Parse(Console.ReadLine());
    Console.WriteLine("Insira a forma de pagamento (1 - à vista, 2 - parcelado");

    int formaPagamento = int.Parse(Console.ReadLine());

    float valorFinal = 0;

    if (formaPagamento == 1)
    {
        valorFinal = valor * 0.9f;
        Console.WriteLine("Valor final com 10% de desconto: " + valorFinal);
    }
    else if (formaPagamento == 2)
    {
        valorFinal = valor * 1.05f;
        Console.WriteLine("Valor final com 5% de juros: " + valorFinal);
    }
    else
    {
        Console.WriteLine("Forma de pagamento inválida");
    }

}
else if (funcao == 7)
{


    //7
    Console.WriteLine("Insira o primeiro lado do triangulo");
    float lado1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Insira o segundo lado do triangulo");
    float lado2 = float.Parse(Console.ReadLine());
    Console.WriteLine("Insira o terceiro lado do triangulo");
    float lado3 = float.Parse(Console.ReadLine());

    float soma12 = lado1 + lado2;
    float soma13 = lado1 + lado3;
    float soma23 = lado2 + lado3;

    if (lado1 < soma23 && lado2 < soma13 && lado3 < soma12)
    {
        Console.WriteLine("Os lados formam um triangulo");
    }
    else
    {
        Console.WriteLine("Os lados não formam um triangulo");
    }

}
else if (funcao == 8)
{
    //8
    Console.WriteLine("Insira a primeira nota");
    float n1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Insira o peso dessa nota");
    float p1 = float.Parse(Console.ReadLine());


    Console.WriteLine("Insira a segunda nota");
    float n2 = float.Parse(Console.ReadLine());

    Console.WriteLine("Insira o peso dessa nota");
    float p2 = float.Parse(Console.ReadLine());


    Console.WriteLine("Insira a terceira nota");
    float n3 = float.Parse(Console.ReadLine());

    Console.WriteLine("Insira o peso dessa nota");
    float p3 = float.Parse(Console.ReadLine());

    float mediaPonderada = ((n1 * p1) + (n2 * p2) + (n3 * p3)) / (p1 + p2 + p3);

    if (mediaPonderada >= 9)
    {
        Console.WriteLine("A");
    }
    else if (mediaPonderada >= 7 && mediaPonderada < 9)
    {
        Console.WriteLine("B");
    }
    else if (mediaPonderada >= 5 && mediaPonderada < 7)
    {
        Console.WriteLine("C");
    }
    else if (mediaPonderada < 5)
    {
        Console.WriteLine("D");
    }

}
else
{
    Console.WriteLine("Nao temos essa funcao");
}