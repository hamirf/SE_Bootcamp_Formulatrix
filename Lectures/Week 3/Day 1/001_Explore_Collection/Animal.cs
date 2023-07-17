public class Animal
{
    public string Name { get; }
    public int leg;

    public Animal(string name, int leg)
    {
        Name = name;
        this.leg = leg;
    }

    public void AnimalInfo()
    {
        if (leg >= 1)
        {
            System.Console.WriteLine($"{Name} has {leg} legs");

        }
        else
        {
            System.Console.WriteLine($"{Name} has {leg} leg");
        }
    }

    public override string? ToString()
    {

        return Name + "has " + leg.ToString() + " leg(s)";
    }
}
