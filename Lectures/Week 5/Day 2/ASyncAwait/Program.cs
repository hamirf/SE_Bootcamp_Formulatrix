class Program
{
    static async Task Main(string[] args)
    {
        System.Console.WriteLine("Hello");
        int t1 = await Task.Run(() => MultiplyByTwoAsync(5));
        System.Console.WriteLine(t1);
        System.Console.WriteLine("Program exited");
    }

    static async Task<int> MultiplyByTwoAsync(int n)
    {
        await Task.Delay(2000);
        return n * 2;
    }
}