namespace _001_Coba_Inheritance;

public class BorderColor : Shape
{
    protected Shape shape;

    public BorderColor(Shape shape)
    {
        this.shape = shape;
    }

    public override void Draw()
    {
        shape.Draw();
        Console.WriteLine("Border Color: Red");
    }

}
