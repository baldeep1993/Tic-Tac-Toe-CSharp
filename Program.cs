using System.Runtime.ConstrainedExecution;

//Console.BackgroundColor = ConsoleColor.Gray;
System.Console.WriteLine("============================================");
System.Console.WriteLine();
System.Console.WriteLine("WELCOME TO TIC-TAC-TOE GAME");
System.Console.WriteLine();
System.Console.WriteLine("============================================");

string[,] board = new string[3, 3] {
         {"1","2","3"},
         {"4","5","6"},
         {"7","8","9"}
        };


//System.Console.WriteLine($"Row Count: {board.GetLength(0)}");

//System.Console.WriteLine($"Column Count: {board.GetLength(1)}");

//Creating the board

for (int row = 0; row < board.GetLength(0); row++)
{
    for (int column = 0; column < board.GetLength(1); column++)
    {
        if (column < 2)
        {
            System.Console.Write(board[row, column] + " | ");
        }
        else
        {
            System.Console.Write(board[row, column]);
        }
    }
    if (row < 2)
    {
        System.Console.WriteLine("\n--x---x--");
    }
    else
    {
        System.Console.WriteLine();
    }
}

//Player Turn Logic

int PlayerACounter = 0;
int PlayerBCounter = 0;

System.Console.WriteLine();

do
{
    Console.WriteLine("Player A: Your turn now. Enter a number between 1-9");
    var playerAInput = Convert.ToInt32(Console.ReadLine());

    if (playerAInput >= 1 && playerAInput <= 9)
    {
        var rowNumber = (playerAInput - 1) / 3;
        var columnNUmber = (playerAInput - 1) % 3;

        System.Console.WriteLine(rowNumber);
        System.Console.WriteLine(columnNUmber);

        board[rowNumber, columnNUmber] = "X";
    }

    PlayerACounter++;

    Console.WriteLine("Player B: Your turn now. Enter a number between 1-9");

    var playerBInput = Convert.ToInt32(Console.ReadLine());

    if (playerBInput >= 1 && playerBInput <= 9)
    {
        var rowNumber = (playerBInput - 1) / 3;
        var columnNUmber = (playerBInput - 1) % 3;

        System.Console.WriteLine(rowNumber);
        System.Console.WriteLine(columnNUmber);

        board[rowNumber, columnNUmber] = "O";
    }

    PlayerBCounter++;

} while (PlayerACounter < 3 && PlayerBCounter < 3);


//Printing the board again

for (int row = 0; row < board.GetLength(0); row++)
{
    for (int column = 0; column < board.GetLength(1); column++)
    {
        if (column < 2)
        {
            System.Console.Write(board[row, column] + " | ");
        }
        else
        {
            System.Console.Write(board[row, column]);
        }
    }
    if (row < 2)
    {
        System.Console.WriteLine("\n--x---x--");
    }
    else
    {
        System.Console.WriteLine();
    }
}

//Winner Declaration

bool winner = false;


//All rows Check

for (int i = 0; i < board.GetLength(0); i++)
{
    if (board[i, 0] == "X" && board[i, 1] == "X" && board[i, 2] == "X")
    {
        winner = true;
        System.Console.WriteLine("Row Match Found");
        break;
    }
}

//All Columns Check

for (int i = 0; i < board.GetLength(1); i++)
{
    if (board[0, i] == "X" && board[1, i] == "X" && board[2, i] == "X")
    {
        winner = true;
        System.Console.WriteLine("Column Match Found");
        break;
    }
}

//First Diagonal Check
int firstDiagonalCheckCounter = 0;

for (int i = 0; i < board.GetLength(0); i++)
{
    if (board[i, i] == "X")
    {
        firstDiagonalCheckCounter++;
    }
}

if (firstDiagonalCheckCounter == 3)
{
    winner = true;
}

//Second Diagonal Check
int boardLength = 2;
int secondDiagonalCheckCounter = 0;

for (int i = 0; i < board.GetLength(0); i++)
{
    if (board[i, boardLength - i] == "X")
    {
        secondDiagonalCheckCounter++;
    }
}

if (secondDiagonalCheckCounter == 3)
{
    winner = true;
    System.Console.WriteLine("Second Diagonal Match Found"); ;
}

if (winner)
{
    System.Console.WriteLine("Player A is winner 🙂");
}
else
{
    System.Console.WriteLine("Player A Lost 😔");
}
