namespace Checkers;

public class GameRunner
{
    private Dictionary<IPlayer, List<Piece>> playerPieces = new();
    private IBoard board;
    private PieceColor pieceColor;
    private Position position;
    private GameStatus gameStatus;

    public GameRunner(IBoard board)
    {
        this.board = board;
    }

    public bool AddPlayer(IPlayer player)
    {
        if (player.GetName() != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}