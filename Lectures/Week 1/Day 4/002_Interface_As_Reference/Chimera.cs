namespace _002_Interface_As_Reference;

public class Chimera : IPet
{
    public void PetAttack()
    {
        Console.WriteLine("Chimera attack with his claws");
    }

    public void PetDefend()
    {
        Console.WriteLine("Chimera uses fireball");
    }

    public void PetSkill()
    {
        Console.WriteLine("Chimera defend the player");
    }
}
