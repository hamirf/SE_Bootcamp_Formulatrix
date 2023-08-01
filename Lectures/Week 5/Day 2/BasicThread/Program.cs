class Program
{
    static void Main(string[] args)
    {
        Thread linkStart = new Thread(() => Console.WriteLine("Link Start\n"));
        Thread createKirito = new Thread(CreateKirito);
        Thread createAsuna = new Thread(CreateAsuna);

        linkStart.Start();
        createKirito.Start();
        createAsuna.Start();
        Thread.Sleep(2000);
        System.Console.WriteLine("Program exited");
    }

    private static void CreateKirito()
    {
        Thread.Sleep(2000);
        Console.WriteLine("Kirito created");
    }

    private static void CreateAsuna()
    {
        Thread.Sleep(2000);
        Console.WriteLine("Asuna created");
    }
}