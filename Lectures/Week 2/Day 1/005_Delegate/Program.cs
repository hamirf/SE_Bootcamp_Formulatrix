public delegate void DelegateOne(int a, int b);

class Program
{
    static void Main()
    {
        int a = 2;
        int b = 7;
        Calculation calc = new();
        DelegateOne delegation = calc.Addition;
        delegation += calc.Substraction;
        delegation += calc.Multiplication;
        delegation += calc.Division;
        delegation += calc.Power;
        delegation(a, b);
    }
}

public class Calculation
{
    public void Addition(int x, int y)
    {
        Console.WriteLine(x + y);
    }
    public void Substraction(int x, int y)
    {
        Console.WriteLine(x - y);
    }
    public void Multiplication(int x, int y)
    {
        Console.WriteLine(x * y);
    }
    public void Division(int x, int y)
    {
        Console.WriteLine(x / y);
    }
    public void Power(int x, int y)
    {
        int result = MathPower(x, y);
        Console.WriteLine(result);
    }
    public int MathPower(int x, int y)
    {
        if (y == 0)
        {
            return 1;
        }
        else
        {
            return x * MathPower(x, y - 1);
        }
    }
}