using Pocket_Monster;

class Program
{
    static void Main()
    {
        Pikachu pikachu = new Pikachu();
        pikachu.eat();
        pikachu.evolve();
        pikachu.cry();

        Charmeleon charmeleon = new Charmeleon();
        charmeleon.eat();
        charmeleon.evolve();
        charmeleon.cry();
    }
}