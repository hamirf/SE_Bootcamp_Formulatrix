namespace Pocket_Monster;

public interface IPokemon
{
    public void Eat();
    public void Evolve();
    public void Cry();
}

public class Pikachu : IPokemon
{
    public void Eat()
    {
        Console.WriteLine("Pikachu eating meat");
    }
    public void Evolve()
    {
        Console.WriteLine("Pikachu evolving to Raichu using Thunder Stone");
    }
    public void Cry()
    {
        Console.WriteLine("Pika Pika~~");
    }
}

public class Charmeleon : IPokemon
{
    public void Eat()
    {
        Console.WriteLine("Charmeleon eating together with Pikachu");
    }
    public void Evolve()
    {
        Console.WriteLine("Charmeleon evolving to Charizard after winning some battle");
    }
    public void Cry()
    {
        Console.WriteLine("Chaaaaar!!");
    }
}
