using Calculator;

class Program
{
    static void Main(string[] args)
    {
        string[] nums;
        bool isA;
        bool isB;

        int a;
        int b;

        do
        {
            Console.Write("Input your desired number (a, b): ");
            nums = Console.ReadLine().Split(',');
            isA = int.TryParse(nums[0], out a);
            isB = int.TryParse(nums[1], out b);
        } while (!isA && !isB);

        ICalculator calculator = new BasicCalculator();
        double add = calculator.Calculate(a, b, "add");
        double sub = calculator.Calculate(a, b, "sub");
        double multiply = calculator.Calculate(a, b, "multiply");
        double divide = calculator.Calculate(a, b, "divide");
        double power = calculator.Calculate(a, b, "power");
        double factorial = calculator.Calculate(a, "factorial");

        Console.WriteLine($"The result of {a} + {b} equals {add}");
        Console.WriteLine($"The result of {a} - {b} equals {sub}");
        Console.WriteLine($"The result of {a} * {b} equals {multiply}");
        Console.WriteLine($"The result of {a} / {b} equals {divide}");
        Console.WriteLine($"The result of {a} to the power of {b} equals {power}");
        Console.WriteLine($"The result of {a}! equals {factorial}");

    }
}