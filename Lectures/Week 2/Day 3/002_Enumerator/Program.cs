class Program
{
    static void Main()
    {
        foreach (var servError in Enum.GetValues(typeof(ServerError)))
        {
            System.Console.WriteLine($"{(int)servError} {servError}");
        }
    }
}