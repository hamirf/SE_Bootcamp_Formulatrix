class Program
{
    static async Task Main(string[] args)
    {
        Console.Write("Input number: ");
        int num = int.Parse(Console.ReadLine());
        int[] power = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Task<int>[] mathPow = power.Select(pow => PowerOf(num, pow)).ToArray();
        int[] results = await Task.WhenAll(mathPow);
        Console.WriteLine("List of 2 power: " + string.Join(", ", results));
        Console.WriteLine("Calculation completed!");
    }

    static async Task<int> PowerOf(int num, int pow)
    {
        await Task.Delay(1000);
        if (pow == 0)
        {
            return 1;
        }
        else
        {
            return num * await PowerOf(num, pow - 1);
        }
    }
}