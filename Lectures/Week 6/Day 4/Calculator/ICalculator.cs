namespace Calculator;

public interface ICalculator
{
    double Calculate(double a, string calculation);
    double Calculate(double a, double b, string calculation);
}
