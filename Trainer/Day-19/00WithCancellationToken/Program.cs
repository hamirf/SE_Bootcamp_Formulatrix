using System.Threading.Tasks;

//Yang dikomen adalah tambahan2, hasil explore
static class Program
{
    static async Task Main()
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " main");
        CancellationTokenSource source = new CancellationTokenSource();
        CancellationToken token = source.Token;

        Task task = Task.Run(() => DoLongRunningLoop(token));
        Task task1 = Task.Run(() => DoCheckUserInput(source));

        // try
        // {
        await task;
        // Console.WriteLine("\nProgram finished");
        // }
        // catch (TaskCanceledException tce)
        // {
        //     System.Console.WriteLine(tce.Message);
        // }
    }
    static async Task DoLongRunningLoop(CancellationToken myToken)
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " DoLongRunningLoop");
        for (int i = 0; i <= 100; i++)
        {
            if (myToken.IsCancellationRequested)
            {
                return;
            }
            Console.WriteLine($"Task : {i}% ");

            await Task.Delay(2000);
            // await Task.Delay(200, myToken);
        }
        Console.WriteLine($"Task Completed");
    }
    static async Task DoCheckUserInput(CancellationTokenSource source)
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " DoCheckUserInput");
        if (Console.ReadKey().KeyChar == ' ')
        {
            source.Cancel();
        }
    }
}