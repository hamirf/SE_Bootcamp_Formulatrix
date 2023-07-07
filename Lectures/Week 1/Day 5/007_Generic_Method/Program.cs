using _007_Generic_Method;

public class ToyBox
{
    private object toy;

    public void AddToy<T>(T newToy)
    {
        toy = newToy;
    }

    public T GetToy<T>()
    {
        return (T)toy;
    }
}
class Program
{
    static void Main()
    {
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