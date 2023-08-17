class Program
{
    static void Main(string[] args)
    {
        Shape rectangle = new Rectangle();
        Shape circle = new Circle();

        Console.WriteLine("======= Shape with basic behaviours =======");
        Console.WriteLine("Normal rectangle with no detail.");
        rectangle.Draw();
        Console.WriteLine("-------------------- 1 --------------------");

        Console.WriteLine("Normal circle with no detail.");
        circle.Draw();
        Console.WriteLine("-------------------- 2 --------------------");
        Console.WriteLine();

        // How to add some detail to the shape?
        Console.WriteLine("======= Shape with extra behaviours =======");
        Shape redBorderCircle = new CircleBorderColor("Red");
        Shape thicknessOf2Circle = new CircleBorderThickness(2);
        Shape blue7ThicknessCircle = new CircleBorderColorThickness("Blue", 7);

        Console.WriteLine("A circle with red border.");
        redBorderCircle.Draw();
        Console.WriteLine("-------------------- 1 --------------------");

        Console.WriteLine("A circle with 2 px thickness of border.");
        thicknessOf2Circle.Draw();
        Console.WriteLine("-------------------- 2 --------------------");

        Console.WriteLine("A circle with blue and 2px thickness border");
        blue7ThicknessCircle.Draw();
        Console.WriteLine("-------------------- 3 --------------------");
    }
}