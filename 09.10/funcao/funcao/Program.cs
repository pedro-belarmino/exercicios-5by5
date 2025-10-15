static double calculateNotes(double n1, double n2, double n3)
{
    double result = (n1 + n2 + n3) / 3;
    return result;
}

static bool verifyNumber(int n)
{
    if (n % 2 == 0) {
        return true;
    } else {
        return false;
    }

}

static int calculateAge(int n)
{

    return DateTime.Now.Year - n;
}


static double realToDolar(double real, double value, double tax)
{
    var convertValue = real / value;
    var taxValue = (convertValue/100) * tax;
    return convertValue - taxValue;
}


static string biggestNumber(double number1, double number2, double number3) {

    if (number1 == number2 && number2 == number3) {
        return "Os 3 numeros são iguais";
    }
    else if (number1 > number2 && number1 > number3) {
        return $"O numero maior é {number1}";
    }
    else if (number2 > number1 && number2 > number3) {
        return $"O numero maior é {number2}";
    }
    else if (number3 > number1 && number3 > number2) {
        return $"O numero maior é {number3}";
    }
    else if (number1 == number2 && number1 > number3) {
        return $"Os dois primeiros numeros são iguais e maiores, {number1}";
    }
    else if (number1 == number3 && number1 > number2) {
        return $"O primero e o terceiro numero são iguais e os maiores, {number1}";
    }
    else if (number2 == number3 && number2 > number1) {
        return $"Os dois últimos números são os maiores, {number2}";
    }
    else return "deu erro";
}


Console.WriteLine("Qual funcao voce quer executar?");
Console.WriteLine("1 - calcular media");
Console.WriteLine("2 - verificar numero");
Console.WriteLine("3 - calcular idade");
Console.WriteLine("4 - converter moeda");
Console.WriteLine("5 - maior entre 3 numeros");

int number =  Convert.ToInt32(Console.ReadLine());

switch (number) {
    case 1: {
            Console.WriteLine("Insira a primeira nota");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a segunda nota");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a terceira nota");
            double n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(calculateNotes(n1, n2, n3)); 
            break;
        }
    case 2: {
            Console.WriteLine("Informa o numero inteiro");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(verifyNumber(n));
        }
        break;
    case 3: {
            Console.WriteLine("Insira o ano que você nasceu");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(calculateAge(n));
        }
        break;
    case 4: {
            Console.WriteLine("Insira o valor em reais que vai ser convertido para dolar");
            double real = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quanto ta o dolar?");
            double value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a taxa do cambio?");
            double tax = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(realToDolar(real, value, tax));
        }
        break;
    case 5: {
            Console.WriteLine("Vamos descobrir o maior dentre 3 numeros");


            Console.WriteLine("Insira o primeiro numero");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o terceiro numero");
            double number3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(biggestNumber(number1, number2, number3));
        }
        break;
}