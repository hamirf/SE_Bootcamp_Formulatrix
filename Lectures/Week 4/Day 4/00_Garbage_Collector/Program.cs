class Program
{
    static void Main()
    {
        CreateProcessor();
        // Processor processor = new(2, 4);
        // Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
        GC.Collect();
        // GC.WaitForPendingFinalizers();
        // Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
    }

    static void CreateProcessor()
    {
        for (int i = 0; i < 100000; i++)
        {
            Processor processor = new();
        }
    }
}

class Processor
{
    int core;
    int thread;

    public Processor()
    {
    }

    public Processor(int core, int thread)
    {
        this.core = core;
        this.thread = thread;
        System.Console.WriteLine($"Processor with {core} core(s) and {thread} thread(s) has been added");
    }
    ~Processor()
    {
        System.Console.WriteLine($"\nProcessor with {core} core(s) and {thread} thread(s) has been demolished");
    }
}