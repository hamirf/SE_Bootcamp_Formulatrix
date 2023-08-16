class Program
{
    static void Main(string[] args)
    {

    }
}

public abstract class Shape
{
    public abstract void Draw();
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Shape: Circle");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Shape: Rectangle");
    }
}

public abstract class ShapeDecorator
{
    protected Shape shape;

    public ShapeDecorator(Shape shape)
    {
        this.shape = shape;
    }

    public void SetShape(Shape shape)
    {
        this.shape = shape;
    }

    public override
}