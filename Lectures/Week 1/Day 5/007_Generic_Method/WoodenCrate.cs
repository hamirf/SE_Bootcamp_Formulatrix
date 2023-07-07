namespace _007_Generic_Method;

public class WoodenCrate
{
    private object _treasure;

    public void AddTreasure<T>(T treasure)
    {
        _treasure = treasure;
    }
    // long tre = 2;
    // obj treas = tre;

    public T GetTreasure<T>()
    {
        return (T)_treasure;
    }
    //treas = (int)treas;
}
