public class TicTacToeBoard
{
    public static void DisplayBoard(string[,] board)
    {

        System.Console.WriteLine("============================================");
        System.Console.WriteLine();
        System.Console.WriteLine("       🎮 WELCOME TO TIC-TAC-TOE 🎮");
        System.Console.WriteLine();
        System.Console.WriteLine("============================================");
        System.Console.WriteLine();
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
}