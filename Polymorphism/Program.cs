using Polymorphism;

class Program
{
    static void Main()
    {
        Bapak anto = new Bapak("Anto");
        anto.Sleep();

        Anak tono = new Anak("Tono");
        tono.Sleep();
        Console.WriteLine(tono.Eat());
        Console.WriteLine(tono.Eat("telur dadar"));
    }
}