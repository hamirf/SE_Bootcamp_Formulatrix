using System.Runtime.Serialization;

[DataContract]
public class Piece
{
    [DataMember]
    private Position _position;

    [DataMember]
    private Rank _rank;

    [DataMember]
    private Color _color;

    public Piece()
    {
    }

    public Piece(Position position, Rank rank, Color color)
    {
        _position = position;
        _rank = rank;
        _color = color;
    }

    public Position GetPosition()
    {
        return _position;
    }

    public void SetPosition(Position position)
    {
        _position = position;
    }


    public Rank GetRank()
    {
        return _rank;
    }

    public void SetRank(Rank rank)
    {
        _rank = rank;
    }

    public Color GetColor()
    {
        return _color;
    }

    public void SetColor(Color color)
    {
        _color = color;
    }

}
