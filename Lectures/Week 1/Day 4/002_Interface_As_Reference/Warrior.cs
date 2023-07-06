namespace _002_Interface_As_Reference;

public class Warrior : IPlayerClass
{
    public string className;

    public Warrior(string className)
    {
        this.className = className;
    }
    public string PlayerAttack()
    {
        return "Attack with a greatsword";
    }

    public string PlayerSkill()
    {
        return "Heavy Slash";
    }
}
