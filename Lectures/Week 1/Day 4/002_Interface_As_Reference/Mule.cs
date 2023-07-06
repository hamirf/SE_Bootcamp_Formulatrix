namespace _002_Interface_As_Reference;

public class Mule : IMount
{
    public void MountJump()
    {
        Console.WriteLine("Mule is walking");
    }

    public void MountRun()
    {
        Console.WriteLine("Mule cannot run");
    }

    public void MountWalk()
    {
        Console.WriteLine("Mule do a little jump");
    }
}
