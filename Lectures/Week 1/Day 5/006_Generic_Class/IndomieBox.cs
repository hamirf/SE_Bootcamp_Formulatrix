namespace _006_Generic_Class;

public class IndomieBox<T>
{
    private T piece;

    public IndomieBox(T banyak)
    {
        piece = banyak;
    }

    public void MiePerBox()
    {
        Console.WriteLine($"Banyaknya indomie per kardus adalah {piece} pcs");
    }
}
