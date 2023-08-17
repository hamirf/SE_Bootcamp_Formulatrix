using _001_Coba_Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Shape rectangle = new Rectangle();
        Shape circle = new Circle();
        Shape redCircle = new BorderColor(circle);

        Console.WriteLine("Normal rectangle with no detail.");
        rectangle.Draw();

        Console.WriteLine("\nA circle with red border.");
        redCircle.Draw();

        // How to add some detail to the shape?
    }
}