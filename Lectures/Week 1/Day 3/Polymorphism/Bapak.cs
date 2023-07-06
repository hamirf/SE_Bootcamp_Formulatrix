namespace Polymorphism;

public class Bapak
{
    public string name;
    public int height;
    public int weight;

    public Bapak(string dadName)
    {
        name = dadName;
    }

    public virtual void Sleep()
    {
        Console.WriteLine($"Bapak {name}, turu neng kamar");
    }
}

public class Anak : Bapak
{
    public string? food;

    public Anak(string nama) : base(nama)
    {
        name = nama;
    }

    // Overriding
    public override void Sleep()
    {
        Console.WriteLine($"{name} turu neng sofa");
    }

    // Overloading
    public string Eat()
    {
        food = $"{name} lagi mangan sego";
        return food;
    }
    public string Eat(string lauk)
    {
        food = $"{name} mangan sego karo {lauk}";
        return food;
    }
}
