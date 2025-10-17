

char[,] board = new char[3, 3];
char currentPlayer = 'X';
int moves = 0;
bool gameOver = false;


for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        board[i, j] = ' ';
    }
}


Console.WriteLine("\n fim de jogo!");


void PrintBoard(char[,] board)
{
    Console.WriteLine("  0 1 2");
    for (int i = 0; i < 3; i++)
    {
        Console.Write(i + " ");
        for (int j = 0; j < 3; j++)
        {
            Console.Write(board[i, j]);
            if (j < 2) Console.Write("|");
        }
        Console.WriteLine();
        if (i < 2) Console.WriteLine("  -----");
    }
}

void ReadMove(char[,] board, char player)
{
    int row, col;
    bool validMove = false;

    do
    {
        Console.WriteLine($"\n jogador {player}, escreva a sua jogada (linha e coluna): ");
        Console.Write("linha: ");
        row = int.Parse(Console.ReadLine());
        Console.Write("coluna: ");
        col = int.Parse(Console.ReadLine());

        if (row < 0 || row > 2 || col < 0 || col > 2)
        {
            Console.WriteLine("posicao invalida, tente novamente.");
        }
        else if (board[row, col] != ' ')
        {
            Console.WriteLine("esse lugar ja foi escolhido, tente novamente.");
        }
        else
        {
            board[row, col] = player;
            validMove = true;
        }
    } while (!validMove);
}

bool CheckWin(char[,] board, char player)
{

    for (int i = 0; i < 3; i++)
    {
        if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
            return true;
    }


    for (int j = 0; j < 3; j++)
    {
        if (board[0, j] == player && board[1, j] == player && board[2, j] == player)
            return true;
    }


    if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
        return true;

    if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
        return true;

    return false;
}


while (!gameOver)
{
    Console.Clear();
    PrintBoard(board);
    ReadMove(board, currentPlayer);
    moves++;

    if (CheckWin(board, currentPlayer))
    {
        Console.Clear();
        PrintBoard(board);
        Console.WriteLine($"jogador {currentPlayer} ganhou!");
        gameOver = true;
    }
    else if (moves == 9)
    {
        Console.Clear();
        PrintBoard(board);
        Console.WriteLine("empate!");
        gameOver = true;
    }
    else
    {
        if (currentPlayer == 'X')
            currentPlayer = 'O';
        else
            currentPlayer = 'X';
    }
}