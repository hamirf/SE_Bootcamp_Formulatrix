using _006_Generic_Class;

class Program
{
    static void Main()
    {
        IndomieBox<int> indomie = new IndomieBox<int>(24);
        indomie.MiePerBox();
        Console.WriteLine("");

        IndomieBox<string> indomie1 = new IndomieBox<string>("empat puluh delapan");
        indomie1.MiePerBox();
        Console.WriteLine("------------------");

        ToyBox<int> intGenericClass = new ToyBox<int>(10);
        int result = intGenericClass.ToyBoxMethod(5);
        Console.WriteLine($"Nilai Mainan: {result}");
        Console.WriteLine("");

        ToyBox<string> stringGenericClass = new ToyBox<string>("Hello");
        string res = stringGenericClass.ToyBoxMethod("World");
        // Console.WriteLine($"Nilai Mainan: {result}");
        Console.WriteLine($"Nilai Mainan: {res}");
    }
}