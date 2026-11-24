using System.Runtime.ConstrainedExecution;


Console.SetCursorPosition(0, 5);

//Console.BackgroundColor = ConsoleColor.Gray;
System.Console.WriteLine("============================================");
System.Console.WriteLine();
System.Console.WriteLine("       🎮 WELCOME TO TIC-TAC-TOE 🎮");
System.Console.WriteLine();
System.Console.WriteLine("============================================");
System.Console.WriteLine();
System.Console.WriteLine("⚔️  TWO PLAYERS. ONE BOARD. ZERO FRIENDSHIP.");
System.Console.WriteLine();
System.Console.WriteLine("🔥 The battle for 9 boxes begins!");
System.Console.WriteLine();
System.Console.WriteLine("Player A: Ready to destroy friendships?");
System.Console.WriteLine("Player B: Ready to blame the game?");
System.Console.WriteLine();
System.Console.WriteLine("Rules are simple:");
System.Console.WriteLine("1. Get 3 in a row to claim victory.");
System.Console.WriteLine("2. Don't cheat. We are watching you!");
System.Console.WriteLine("3. No crying if you lose.");
System.Console.WriteLine();
System.Console.WriteLine("LET THE BATTLE BEGIN!");
System.Console.WriteLine();
System.Console.WriteLine("============================================");

string[,] board = new string[3, 3] {
         {"1","2","3"},
         {"4","5","6"},
         {"7","8","9"}
        };

//System.Console.WriteLine($"Row Count: {board.GetLength(0)}");

//System.Console.WriteLine($"Column Count: {board.GetLength(1)}");

//Creating the board=====================================================================

//In order to Create the Board we can use a Method;

static void DisplayBoard(string[,] board)
{

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
}

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

//==========================================================================================

//Player Turn Logic=========================================================================

int PlayerACounter = 0;
int PlayerBCounter = 0;

System.Console.WriteLine();

do
{
    bool playerAIsAlreadySelected = false; //This bool variable will check if no same Cell is selected by Players A
    bool playerBIsAlreadySelected = false; //This bool variable will check if no same Cell is selected by Players B

    do
    {
        Console.WriteLine("Player A: Your turn now. Enter a number between 1-9");
        bool playerAIsValidInteger = false;

        int playerAInput;

        string? playerAInputString = Console.ReadLine();

        if (playerAInputString == null)
        {
            System.Console.WriteLine("You have entered null. Please try again");
            continue;
        }
        else
        {
            playerAIsValidInteger = int.TryParse(playerAInputString, out playerAInput);

            if (playerAIsValidInteger)
            {
                if (playerAInput >= 1 && playerAInput <= 9)
                {
                    var rowNumber = (playerAInput - 1) / 3;
                    var columnNUmber = (playerAInput - 1) % 3;

                    //System.Console.WriteLine(rowNumber);
                    //System.Console.WriteLine(columnNUmber);


                    if (board[rowNumber, columnNUmber] == "X" || board[rowNumber, columnNUmber] == "O")
                    {
                        System.Console.WriteLine($"‼️Player A, board[{rowNumber},{columnNUmber}] is already taken. Please select any other cell.");
                    }
                    else
                    {
                        board[rowNumber, columnNUmber] = "X";
                        playerAIsAlreadySelected = true;
                        PlayerACounter++;
                        DisplayBoard(board);
                        System.Console.WriteLine();
                    }
                }
                else
                {
                    System.Console.WriteLine("⚠️ Player A, You have entered a number that is out of range for board.");
                }
            }
            else
            {
                System.Console.WriteLine("⚠️Player A, the input you have provided is not a valid Integer. Please try again. 🙂");
            }
        }


    } while (playerAIsAlreadySelected == false);

    do
    {
        bool playerBIsValidInteger = false;

        Console.WriteLine("Player B: Your turn now. Enter a number between 1-9");

        int playerBInput;
        string? playerBInputString = Console.ReadLine();

        if (playerBInputString == null)
        {
            System.Console.WriteLine("You have entered null. Please try again");
            continue;
        }
        else
        {
            playerBIsValidInteger = int.TryParse(playerBInputString, out playerBInput);

            if (playerBIsValidInteger)
            {
                if (playerBInput >= 1 && playerBInput <= 9)
                {
                    var rowNumber = (playerBInput - 1) / 3;
                    var columnNUmber = (playerBInput - 1) % 3;

                    //System.Console.WriteLine(rowNumber);
                    //System.Console.WriteLine(columnNUmber);

                    if (board[rowNumber, columnNUmber] == "X" || board[rowNumber, columnNUmber] == "O")
                    {
                        System.Console.WriteLine($"‼️Player B, board[{rowNumber},{columnNUmber}] is already taken. Please select any other cell.");
                    }
                    else
                    {
                        board[rowNumber, columnNUmber] = "O";
                        playerBIsAlreadySelected = true;
                        PlayerBCounter++;
                        DisplayBoard(board);
                        System.Console.WriteLine();
                    }
                }
                else
                {
                    System.Console.WriteLine("⚠️ Player B, You have entered a number that is out of range for board.");
                }
            }
            else
            {
                System.Console.WriteLine("⚠️Player B, the input you have provided is not a valid Integer. Please try again. 🙂");
            }
        }



    } while (playerBIsAlreadySelected == false);

} while (PlayerACounter < 3 && PlayerBCounter < 3);

//==========================================================================================

//Winner Declaration

System.Console.WriteLine("And the Winner is..");
System.Console.WriteLine("===================");
System.Console.WriteLine();

bool playerAWinner = false;


//All rows Check

for (int i = 0; i < board.GetLength(0); i++)
{
    if (board[i, 0] == "X" && board[i, 1] == "X" && board[i, 2] == "X")
    {
        playerAWinner = true;
        System.Console.WriteLine("Row Match Found");
        break;
    }
}

//All Columns Check

for (int i = 0; i < board.GetLength(1); i++)
{
    if (board[0, i] == "X" && board[1, i] == "X" && board[2, i] == "X")
    {
        playerAWinner = true;
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
    playerAWinner = true;
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
    playerAWinner = true;
    System.Console.WriteLine("Second Diagonal Match Found"); ;
}

if (playerAWinner)
{
    System.Console.WriteLine("Player A is winner 🙂");
}
else
{
    System.Console.WriteLine("Player A Lost 😔");
}


//PlayerB Winner Check

bool playerBWinner = false;


//All rows Check

for (int i = 0; i < board.GetLength(0); i++)
{
    if (board[i, 0] == "O" && board[i, 1] == "O" && board[i, 2] == "O")
    {
        playerBWinner = true;
        System.Console.WriteLine("Row Match Found");
        break;
    }
}

//All Columns Check

for (int i = 0; i < board.GetLength(1); i++)
{
    if (board[0, i] == "O" && board[1, i] == "O" && board[2, i] == "O")
    {
        playerBWinner = true;
        System.Console.WriteLine("Column Match Found");
        break;
    }
}

//First Diagonal Check
int playerBfirstDiagonalCheckCounter = 0;

for (int i = 0; i < board.GetLength(0); i++)
{
    if (board[i, i] == "X")
    {
        playerBfirstDiagonalCheckCounter++;
    }
}

if (playerBfirstDiagonalCheckCounter == 3)
{
    playerAWinner = true;
}

//Second Diagonal Check
int playerBsecondDiagonalCheckCounter = 0;

for (int i = 0; i < board.GetLength(0); i++)
{
    if (board[i, boardLength - i] == "X")
    {
        playerBsecondDiagonalCheckCounter++;
    }
}

if (playerBsecondDiagonalCheckCounter == 3)
{
    playerBWinner = true;
    System.Console.WriteLine("Second Diagonal Match Found"); ;
}

if (playerBWinner)
{
    System.Console.WriteLine("Player B is winner 🙂");
}
else
{
    System.Console.WriteLine("Player B Lost 😔");
}