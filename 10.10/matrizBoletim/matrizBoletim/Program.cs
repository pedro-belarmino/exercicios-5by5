string[] subjects = ["Português", "Matemática", "Ciências", "História", "Geografia"];
string[] situation = new string[5];

int[,] buildMatrix(int lin = 5, int col = 4)
{
    return new int[lin, col];
}

bool validateStudent(int v1, int v2, int v3, int v4)
{
    if ((v1 + v2 + v3 + v4) / 4 < 5)
    {
        return false;
    }
    else
    {
        return true;
    }
}

int generateGrade()
{
    return Random.Shared.Next(1, 11);
}

void fillTable(int[,] matrix)
{
    for (int i = 0; i < subjects.Length; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            matrix[i, j] = generateGrade();
        }

        bool approved = validateStudent(matrix[i, 0], matrix[i, 1], matrix[i, 2], matrix[i, 3]);
        situation[i] = approved ? "Aprovado" : "Reprovado";
    }
}

void printTable(int[,] matrix)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Matéria     N1  N2  N3  N4  Média  Situação");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("----------------------------------------------");
    Console.ResetColor();


    for (int i = 0; i < subjects.Length; i++)
    {
        int n1 = matrix[i, 0];
        int n2 = matrix[i, 1];
        int n3 = matrix[i, 2];
        int n4 = matrix[i, 3];
        double avg = (n1 + n2 + n3 + n4) / 4.0;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($"{subjects[i],-10} ");
        Console.ResetColor();
        
        Console.Write($"{n1,2}  {n2,2}  {n3,2}  {n4,2}   {avg,5:F2}  ");

        if (situation[i] != "Aprovado")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{situation[i]} \n");
            Console.ResetColor();
        }
        if (situation[i] != "Reprovado")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{situation[i]} \n");
            Console.ResetColor();
        }
    }
}


int[,] boletim = buildMatrix();
fillTable(boletim);
printTable(boletim);
