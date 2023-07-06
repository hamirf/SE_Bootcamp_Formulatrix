namespace _002_Interface_As_Reference;

public class Warrior : IPlayerClass
{
    public void PlayerAttack()
    {
        Console.WriteLine("Warrior attacks with sword");
    }

    public void PlayerSkill()
    {
        Console.WriteLine("Warrior uses Heavy Slash");
    }
}
