public class CircleBorderColor : Shape
{
    public CircleBorderColor(string color)
    {
        Color = color;
    }

    public string Color { get; set; }

    public override void Draw()
    {
        Console.WriteLine("Shape: Circle");
        Console.WriteLine($"Border Color: {Color}");
    }
}