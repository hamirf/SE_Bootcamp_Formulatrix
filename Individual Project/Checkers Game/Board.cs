namespace Checkers;

public class Board : IBoard
{
    private int size;

    public int GetSize()
    {
        return size;
    }

    public bool SetSize(int size)
    {
        if (size == 64)
        {
            this.size = size;
            return true;
        }
        else
        {
            return false;
        }
    }
}