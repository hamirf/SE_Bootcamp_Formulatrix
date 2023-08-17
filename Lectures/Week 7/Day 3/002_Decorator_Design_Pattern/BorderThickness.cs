//* Concrete Decorator
public class BorderThickness : ShapeDecorator
{
    public BorderThickness(Shape shape) : base(shape)
    {
    }

    public BorderThickness(Shape shape, int thickness) : base(shape)
    {
        Thickness = thickness;
    }

    public int Thickness { get; set; }

    public override string Draw()
    {
        return shape.Draw() + $"\nBorder Thickness : {Thickness} px";
    }
}