//* Base Decorator
public abstract class ShapeDecorator : Shape
{
    protected Shape shape;

    public ShapeDecorator(Shape shape)
    {
        this.shape = shape;
    }

    public override string Draw()
    {
        return shape.Draw();
    }
}
