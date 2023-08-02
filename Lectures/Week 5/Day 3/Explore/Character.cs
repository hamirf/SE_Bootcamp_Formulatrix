public class Character
{
    public Character()
    {
    }

    public Character(string name, Class heroClass)
    {
        Name = name;
        this.heroClass = heroClass;
    }

    public string Name { get; set; }
    public Class heroClass { get; set; }

}