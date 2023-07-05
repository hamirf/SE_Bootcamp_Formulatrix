namespace Pocket_Monster;

public interface Pokemon
{
    public void eat();
    public void evolve();
    public void cry();
}

public class Pikachu : Pokemon
{
    public void eat()
    {
        Console.WriteLine("Pikachu eating meat");
    }
    public void evolve()
    {
        Console.WriteLine("Pikachu evolving to Raichu using Thunder Stone");
    }
    public void cry()
    {
        Console.WriteLine("Pika Pika~~");
    }
}

public class Charmeleon : Pokemon
{
    public void eat()
    {
        Console.WriteLine("Charmeleon eating together with Pikachu");
    }
    public void evolve()
    {
        Console.WriteLine("Charmeleon evolving to Charizard after winning some battle");
    }
    public void cry()
    {
        Console.WriteLine("Chaaaaar!!");
    }
}
