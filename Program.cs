using System.Runtime.ConstrainedExecution;

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

//Creating the board=====================================================================

//In order to Create the Board we can use a Method;

TicTacToeBoard.DisplayBoard(board);

//==========================================================================================

//Player Turn Logic=========================================================================

int PlayerACounter = 0;
int PlayerBCounter = 0;

System.Console.WriteLine();

do
{
    bool playerATurnCompleted = false; //This bool variable will check if no same Cell is selected by Players A
    bool playerBTurnCompleted = false; //This bool variable will check if no same Cell is selected by Players B

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
                        System.Console.WriteLine($"‼️ Player A, Board[{rowNumber},{columnNUmber}] is already taken. Please select any other cell.");
                        System.Console.WriteLine();
                    }
                    else
                    {
                        Console.Clear();
                        board[rowNumber, columnNUmber] = "X";

                        playerATurnCompleted = true;
                        PlayerACounter++;

                        TicTacToeBoard.DisplayBoard(board); //Calling the Method

                        System.Console.WriteLine();
                    }
                }
                else
                {
                    System.Console.WriteLine("⚠️ Player A, You have entered a number that is out of range for board.");
                    System.Console.WriteLine();
                }
            }
            else
            {
                System.Console.WriteLine("⚠️ Player A, the input you have provided is not a valid Integer. Please try again. 🙂");
                System.Console.WriteLine();
            }
        }


    } while (playerATurnCompleted == false);

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
                        System.Console.WriteLine($"‼️ Player B, Board[{rowNumber},{columnNUmber}] is already taken. Please select any other cell.");
                        System.Console.WriteLine();
                    }
                    else
                    {
                        Console.Clear();
                        board[rowNumber, columnNUmber] = "O";

                        playerBTurnCompleted = true;
                        PlayerBCounter++;

                        TicTacToeBoard.DisplayBoard(board); //Calling the Method

                        System.Console.WriteLine();
                    }
                }
                else
                {
                    System.Console.WriteLine("⚠️ Player B, You have entered a number that is out of range for board.");
                    System.Console.WriteLine();
                }
            }
            else
            {
                System.Console.WriteLine("⚠️ Player B, the input you have provided is not a valid Integer. Please try again. 🙂");
                System.Console.WriteLine();
            }
        }



    } while (playerBTurnCompleted == false);

} while (PlayerACounter < 3 && PlayerBCounter < 3);

//==========================================================================================

//Winner Declaration

System.Console.WriteLine("And the Winner is..");
System.Console.WriteLine("===================");
System.Console.WriteLine();

bool playerAResult = PlayerAWinnerCheck.WinnerCheck(board);

bool playerBResult = PlayerBWinnerCheck.WinnerCheck(board);

if (playerAResult)
{
    System.Console.WriteLine("Player A has WON the Game");
}
else if (playerBResult)
{
    System.Console.WriteLine("Player B has WON the Game");
}
else
{
    System.Console.WriteLine("Match Draw");
}

