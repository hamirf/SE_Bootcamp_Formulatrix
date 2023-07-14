partial class Program
{
    static void Main()
    {
        int a = 10;
        int b = 2;

        int addition = Add(a, b);
        Display(addition);
        int substraction = Subs(a, b);
        Display(substraction);
        double multiplication = Multiple(a, b);
        Display(multiplication);
        double division = Divide(a, b);
        Display(division);
    }
}