public class CircleBorderThickness : Shape
{
    public CircleBorderThickness(int thickness)
    {
        Thickness = thickness;
    }

    public int Thickness { get; private set; }

    public override void Draw()
    {
        Console.WriteLine("Shape: Circle");
        Console.WriteLine("Border Thickness: {Thickness} px");
    }
}