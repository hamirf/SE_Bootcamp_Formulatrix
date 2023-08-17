//* Concrete Decorator
public class BorderColor : ShapeDecorator
{
    public BorderColor(Shape shape) : base(shape)
    {
    }

    public BorderColor(Shape shape, string color) : base(shape)
    {
        Color = color;
    }

    public string? Color { get; set; }

    public override string Draw()
    {
        return shape.Draw() + $"\nBorder Color\t : {Color}";
    }
}
