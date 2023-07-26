namespace Checkers;

public class Position
{
    private int x;
    private int y;

    public Position(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public int GetX()
    {
        return x;
    }

    public bool SetX(int x)
    {
        if (x != 0)
        {
            this.x = x;
            return true;
        }
        else
        {
            return false;
        }
    }

    public int GetY()
    {
        return y;
    }

    public bool SetY(int y)
    {
        if (y != 0)
        {
            this.y = y;
            return true;
        }
        else
        {
            return false;
        }
    }
}