class Program
{
    static async Task Main(string[] args)
    {
        System.Console.WriteLine("Calculation of 2 started");
        double[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Task<double>[] multiply = nums.Select(n => MultiplyByTwo(n)).ToArray();
        Task<double>[] divide = nums.Select(n => DivideByTwo(n)).ToArray();
        Task<double>[] add = nums.Select(n => AddByTwo(n)).ToArray();
        Task<double>[] sub = nums.Select(n => SubtractByTwo(n)).ToArray();
        Task<double>[] factorial = nums.Select(n => Factorial(n)).ToArray();

        double[] multiRes = await Task.WhenAll(multiply);
        double[] divRes = await Task.WhenAll(divide);
        double[] addRes = await Task.WhenAll(add);
        double[] subRes = await Task.WhenAll(sub);
        double[] factorialRes = await Task.WhenAll(factorial);

        Console.WriteLine();
        Console.WriteLine("Multiplication: " + string.Join("; ", multiRes));
        Console.WriteLine("Division: " + string.Join("; ", divRes));
        Console.WriteLine("Addition: " + string.Join("; ", addRes));
        Console.WriteLine("Substraction: " + string.Join("; ", subRes));
        Console.WriteLine("Factorial: " + string.Join("; ", factorialRes));
    }

    static async Task<double> Factorial(double n)
    {
        await Task.Delay(1000);
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * await Factorial(n - 1);
        }
    }

    static async Task<double> SubtractByTwo(double n)
    {
        await Task.Delay(2000);
        return n - 2;
    }

    static async Task<double> AddByTwo(double n)
    {
        await Task.Delay(2000);
        return n + 2;
    }

    static async Task<double> DivideByTwo(double n)
    {
        await Task.Delay(2000);
        return n / 2;
    }

    static async Task<double> MultiplyByTwo(double n)
    {
        await Task.Delay(2000);
        return n * 2;
    }
}