namespace _003_Interface;

public class Dragon : ITiger, IBird, IFlamethrower
{
    public void Claws()
    {
        Console.WriteLine("Dragon is using its claws");
    }

    public void Eat()
    {
        Console.WriteLine("Dragon is eating meat");
    }

    public void Flamethrower()
    {
        Console.WriteLine("Dragon is exhale its flamethrower");
    }

    public void Fly()
    {
        Console.WriteLine("Dragon is flying around the city");
    }

    public void Sleep()
    {
        Console.WriteLine("Dragon is sleeping in the cave");
    }

    public void Walk()
    {
        Console.WriteLine("Dragon is walking around the castle");
    }

}
