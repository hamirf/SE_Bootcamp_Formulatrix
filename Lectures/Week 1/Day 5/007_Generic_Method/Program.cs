using _007_Generic_Method;

public class ToyBox
{
    private object _toy;

    public void AddToy<T>(T newToy)
    {
        _toy = newToy;
    }

    public T GetToy<T>()
    {
        return (T)_toy;
    }
}
class Program
{
    static void Main()
    {
        WoodenCrate common = new();
        WoodenCrate uncommon = new();
        WoodenCrate rare = new();

        common.AddTreasure<string>("Chimera Neklace");
        uncommon.AddTreasure<int>(2);
        // uncommon.AddTreasure<long>(2); // Error, tidak bisa casting
        rare.AddTreasure<decimal>(4.00M);

        // float notCommon = uncommon.GetTreasure<int>();

        Console.WriteLine(common.GetTreasure<string>());
        // Console.WriteLine(notCommon);
        Console.WriteLine(uncommon.GetTreasure<long>()); // (int)2
        // Console.WriteLine((int)uncommon.GetTreasure<long>());
        // Console.WriteLine((long)uncommon.GetTreasure<int>());
        Console.WriteLine(rare.GetTreasure<decimal>());
        Console.WriteLine("==================");

        ToyBox toyBox = new ToyBox();
        ToyBox toyBox1 = new ToyBox();
        ToyBox toyBox2 = new ToyBox();

        toyBox.AddToy<string>("Teddy Bear");
        toyBox1.AddToy<int>(42);
        toyBox2.AddToy<double>(3.14);
        // Console.WriteLine("==================");

        string teddyBear = toyBox.GetToy<string>();
        int number = toyBox1.GetToy<int>();
        double pi = toyBox2.GetToy<double>();
        // Console.WriteLine("==================");

        Console.WriteLine(teddyBear);
        Console.WriteLine(number);
        Console.WriteLine(pi);
        // Console.WriteLine("==================");
    }
}