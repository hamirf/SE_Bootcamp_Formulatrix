class Program
{
    static void Main(string[] args)
    {
        Client you = new Client();
        Shape ordiCircle = new Circle();
        Shape ordiRectangle = new Rectangle();

        BorderColor redCircle = new BorderColor(ordiCircle, "Red");
        BorderColor blueRectangle = new BorderColor(ordiRectangle, "Blue");
        BorderThickness blue2Rectangle = new BorderThickness(blueRectangle, 2);

        Console.WriteLine("======= Shape with basic behaviours =======");
        you.ClientCode(ordiCircle);
        you.ClientCode(ordiRectangle);

        Console.WriteLine("======= Shape with extra behaviours =======");
        you.ClientCode(redCircle);
        Console.WriteLine("-------------------- 1 --------------------");
        you.ClientCode(blue2Rectangle);
        Console.WriteLine("-------------------- 2 --------------------");

        object x = 2;
         
        Console.WriteLine(x.ToString());
    }
}