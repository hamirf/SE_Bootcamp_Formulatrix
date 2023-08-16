class Program
{
    static void Main(string[] args)
    {
        Shape rectangle = new Rectangle();
        Shape circle = new Circle();

        Console.WriteLine("Normal rectangle with no detail.");
        rectangle.Draw();

        Console.WriteLine("\nNormal circle with no detail.");
        circle.Draw();

        // How to add some detail to the shape?
    }
}