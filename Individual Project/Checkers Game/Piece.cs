namespace Checkers;

public class Piece
{
    private Rank rank;
    private Position position;

    public Rank GetRank()
    {
        return rank;
    }

    public bool SetRank(Rank rank)
    {
        if (rank.Equals(this.rank))
        {
            this.rank = rank;
            return true;
        }
        else
        {
            return false;
        }
    }
    public Position GetPosition()
    {
        return position;
    }

    public bool SetPosition(Position position)
    {
        if (position != null)
        {
            this.position = position;
            return true;
        }
        else
        {
            return false;
        }
    }
}