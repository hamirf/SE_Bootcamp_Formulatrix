public class CircleBorderColorThickness : Shape
{
    public CircleBorderColorThickness(string color, int thickness)
    {
        Color = color;
        Thickness = thickness;
    }

    public string Color { get; private set; }
    public int Thickness { get; private set; }

    public override void Draw()
    {
        Console.WriteLine("Shape: Circle");
        Console.WriteLine($"Border Color: {Color}");
        Console.WriteLine($"Border Thickness: {Thickness}");
    }
}