namespace Calculator;

public class BasicCalculator : ICalculator
{
    public double Addition(double a, double b)
    {
        return a + b;
    }

    public double Subtraction(double a, double b)
    {
        return a - b;
    }

    public double Multiplication(double a, double b)
    {
        return a * b;
    }

    public double Division(double a, double b)
    {
        return a / b;
    }

    public double Power(double a, double b)
    {
        if (b == 0)
        {
            return 1;
        }
        else
        {
            return a * Power(a, b - 1);
        }
    }

    public double Factorial(double a)
    {
        if (a == 0)
        {
            return 1;
        }
        else
        {
            return a * Factorial(a - 1);
        }
    }

    public double Calculate(double a, string calculation)
    {
        switch (calculation)
        {
            case "factorial":
                return Factorial(a);
            default:
                throw new Exception("There's no such calculation on this calculator");
        }
    }

    public double Calculate(double a, double b, string calculation)
    {
        switch (calculation)
        {
            case "add":
                return Addition(a, b);
            case "sub":
                return Subtraction(a, b);
            case "multiply":
                return Multiplication(a, b);
            case "divide":
                return Division(a, b);
            case "power":
                return Power(a, b);
            default:
                throw new Exception("There's no such calculation on this calculator");
        }
    }

}
