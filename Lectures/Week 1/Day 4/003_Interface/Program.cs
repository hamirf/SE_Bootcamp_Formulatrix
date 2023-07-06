using _003_Interface;

class Program
{
    static void Main()
    {
        Dragon dragon = new();
        dragon.Claws();
        dragon.Flamethrower();
        dragon.Eat();
        dragon.Sleep();
        dragon.Fly();
        dragon.Walk();
    }
}