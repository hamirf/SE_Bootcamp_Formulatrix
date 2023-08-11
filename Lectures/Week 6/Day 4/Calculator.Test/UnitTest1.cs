namespace Calculator.Test;

public class Tests
{
    private ICalculator calculator;
    [SetUp]
    public void Setup()
    {
        calculator = new BasicCalculator();
    }

    [TestCase(2, 7, 9)]
    [TestCase(47, 53, 100)]
    public void AdditionTest(double a, double b, double expected)
    {
        double actual = calculator.Calculate(a, b, "add");
        Assert.That(expected, Is.EqualTo(actual));
    }

    [TestCase(7, 2, 5)]
    [TestCase(100, 99, 1)]
    [TestCase(0, 0, 0)]
    public void SubstractionTest(double a, double b, double expected)
    {
        double actual = calculator.Calculate(a, b, "sub");
        Assert.That(expected, Is.EqualTo(actual));
    }

    [TestCase(2, 7, 14)]
    [TestCase(27, 5, 135)]
    [TestCase(1, 0, 0)]
    [TestCase(22, 1, 22)]
    public void MultiplicationTest(double a, double b, double expected)
    {
        double actual = calculator.Calculate(a, b, "multiply");
        Assert.That(expected, Is.EqualTo(actual));
    }

    [TestCase(7, 2, 3.5)]
    [TestCase(70, 7, 10)]
    [TestCase(2, 4, 0.5)]
    [TestCase(1, 4, 0.25)]
    public void DivisionTest(double a, double b, double expected)
    {
        double actual = calculator.Calculate(a, b, "divide");
        Assert.That(expected, Is.EqualTo(actual));
    }

    [TestCase(2, 3, 8)]
    [TestCase(3, 3, 27)]
    [TestCase(2, 10, 1024)]
    [TestCase(5, 4, 625)]
    public void PowerTest(double a, double b, double expected)
    {
        double actual = calculator.Calculate(a, b, "power");
        Assert.That(expected, Is.EqualTo(actual));
    }

    [TestCase(1, 1)]
    [TestCase(2, 2)]
    [TestCase(3, 6)]
    [TestCase(4, 24)]
    [TestCase(5, 120)]
    [TestCase(6, 720)]
    [TestCase(7, 5040)]
    public void FactorialTest(double a, double expected)
    {
        double actual = calculator.Calculate(a, "factorial");
        Assert.That(expected, Is.EqualTo(actual));
    }
}