public class PlayerAWinnerCheck
{
    public static bool WinnerCheck(string[,] board)
    {
        bool playerAWinner = false;

        //All rows Check

        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (board[i, 0] == "X" && board[i, 1] == "X" && board[i, 2] == "X")
            {
                playerAWinner = true;
                break;
            }
        }

        //All Columns Check

        for (int i = 0; i < board.GetLength(1); i++)
        {
            if (board[0, i] == "X" && board[1, i] == "X" && board[2, i] == "X")
            {
                playerAWinner = true;
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
        }

        return playerAWinner;
    }
}