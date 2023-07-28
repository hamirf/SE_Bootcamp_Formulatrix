// using CheckersGameLib;

public class GameRunner
{
    IBoard board;

    public GameRunner()
    {
    }

    public GameRunner(IBoard board)
    {
        this.board = board;
        for (int i = 0; i < board.GetSize(); i++)
        {
            // System.Console.WriteLine();
            // System.Console.Write("_______________");
            // System.Console.WriteLine();
            if (i == 0)
            {
                System.Console.WriteLine("+---+---+---+---+---+---+---+---+");
            }
            for (int j = 0; j <= board.GetSize(); j++)
            {
                if (j == board.GetSize())
                {
                    System.Console.Write("|");
                }
                else
                {
                    System.Console.Write("|   ");
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("+---+---+---+---+---+---+---+---+");
        }
    }
}