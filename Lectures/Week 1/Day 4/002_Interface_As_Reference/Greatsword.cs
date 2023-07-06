namespace _002_Interface_As_Reference;

public class Greatsword : IWeapon
{
    public void AttackRange()
    {
        Console.WriteLine("Greatsword attack range is melee");
    }

    public void WeaponClass()
    {
        Console.WriteLine("Greatsword only used by Warrior Class");
    }

    public void WeaponVulnerability()
    {
        Console.WriteLine("Greatsword vulnerability now is 75%");
    }
}
