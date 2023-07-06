namespace _002_Interface_As_Reference;

public class Greatsword : IWeapon
{
    public string AttackRange()
    {
        return "Greatsword attack range is melee";
    }

    public string WeaponClass()
    {
        return "Greatsword only used by Warrior Class";
    }

    public string WeaponVulnerability()
    {
        return "Greatsword vulnerability now is 75%";
    }
}
