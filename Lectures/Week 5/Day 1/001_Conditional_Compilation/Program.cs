// #define ONDEVELOPO
#define RELEASE

using CharacterDetail;

class Program
{
    static void Main(string[] args)
    {
        Character lina = new Character("Lina", 9, 150, 12, 1.5);
        Character qop = new Character("Queen of Pain", 9, 125, 20, 1);

#if DEBUG
        // System.Console.WriteLine(lina.Attack(qop));
        Console.WriteLine(lina.GetName() + "'s attack speed: " + lina.GetAspd());
        // System.Console.WriteLine(qop.DecreaseHealth(lina));

        // System.Console.WriteLine(qop.Attack(lina));
        Console.WriteLine(qop.GetName() + "'s attack speed: " + qop.GetAspd());
        // System.Console.WriteLine(lina.DecreaseHealth(qop));

        while (lina.GetHealth() > 0 || qop.GetHealth() > 0)
        {
            Console.WriteLine(lina.DecreaseHealth(qop));
            Console.WriteLine(qop.DecreaseHealth(lina));
            if (lina.GetHealth() <= 0)
            {
                System.Console.WriteLine($"{qop.GetName()} Win!");
                break;
            }
            else if (qop.GetHealth() <= 0)
            {
                System.Console.WriteLine($"{lina.GetName()} Win!");
                break;
            }
        }
#elif RELEASE
        System.Console.WriteLine(lina.Attack(qop));
        System.Console.WriteLine(qop.Attack(lina));
#else
        System.Console.WriteLine("There's nothing this program can do");
#endif
    }
}