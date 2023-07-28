public class Board : IBoard
{
    private int _size;
    public int GetSize()
    {
        return _size;
    }

    public bool SetSize(int size)
    {
        if (size == 8)
        {
            _size = size;
            return true;
        }
        return false;
    }
}
