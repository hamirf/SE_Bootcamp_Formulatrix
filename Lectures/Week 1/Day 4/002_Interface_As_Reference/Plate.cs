namespace _002_Interface_As_Reference;

public class Plate : IArmor
{
    public void ArmorResistance()
    {
        Console.WriteLine("Plate Armor has high Resistance of range attack");
    }

    public void ArmorVulnerability()
    {
        Console.WriteLine("This plate armor vulnerability now is 80%");
    }
}
