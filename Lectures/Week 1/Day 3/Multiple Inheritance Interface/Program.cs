using Pocket_Monster;

class Program
{
    static void Main()
    {
        Pikachu pikachu = new Pikachu();
        pikachu.Eat();
        pikachu.Evolve();
        pikachu.Cry();

        Charmeleon charmeleon = new Charmeleon();
        charmeleon.Eat();
        charmeleon.Evolve();
        charmeleon.Cry();
    }
}