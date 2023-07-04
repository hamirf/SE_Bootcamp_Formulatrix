namespace Graphic_Card_Detail;

public class Graphic_Card
{
    public string name;
    public int power;

    public Graphic_Card(string name) {
        this.name = name;
    }

    public void Stock() {
        Console.WriteLine("Ready Stock");
    }

    public void TDP(int power) {
        Console.WriteLine($"{name} has TDP around {power} W");
    }
}
