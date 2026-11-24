public class PlayerBWinnerCheck
{
    public static bool WinnerCheck(string[,] board)
    {
        bool playerBWinner = false;

        //All rows Check

        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (board[i, 0] == "O" && board[i, 1] == "O" && board[i, 2] == "O")
            {
                playerBWinner = true;
                break;
            }
        }

        //All Columns Check

        for (int i = 0; i < board.GetLength(1); i++)
        {
            if (board[0, i] == "O" && board[1, i] == "O" && board[2, i] == "O")
            {
                playerBWinner = true;
                break;
            }
        }

        //First Diagonal Check
        int firstDiagonalCheckCounter = 0;

        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (board[i, i] == "O")
            {
                firstDiagonalCheckCounter++;
            }
        }

        if (firstDiagonalCheckCounter == 3)
        {
            playerBWinner = true;
        }

        //Second Diagonal Check
        int boardLength = 2;
        int secondDiagonalCheckCounter = 0;

        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (board[i, boardLength - i] == "O")
            {
                secondDiagonalCheckCounter++;
            }
        }

        if (secondDiagonalCheckCounter == 3)
        {
            playerBWinner = true;
        }

        return playerBWinner;
    }
}