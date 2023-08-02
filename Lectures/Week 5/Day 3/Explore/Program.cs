class Program
{
    public static async Task Main(string[] args)
    {
        CancellationTokenSource sc = new CancellationTokenSource();
        CancellationToken token = sc.Token;
        Character haiqi = new Character();

        Task createCharacter = Task.Run(() => DoCreateCharacter(haiqi, token));
        Task interrupt = Task.Run(() => DoInterrupt(sc));

        try
        {
            await createCharacter;
        }
        catch (System.Exception)
        {
            System.Console.WriteLine("Character creation canceled!!");
        }
    }

    private static void DoInterrupt(CancellationTokenSource sc)
    {
        do
        {
            if (Console.ReadKey().KeyChar == (char)8)
            {
                sc.Cancel();
            }
        } while (Console.ReadKey().KeyChar != (char)8);
    }

    private static async Task DoCreateCharacter(Character character, CancellationToken token)
    {
        character.Name = "Haiqi";
        character.heroClass = Class.Warrior;
        System.Console.WriteLine("Starting to create character");
        for (int i = 0; i <= 100; i++)
        {
            if (token.IsCancellationRequested)
            {
                return;
            }
            System.Console.WriteLine($"Creating Character... {i}%");

            await Task.Delay(200, token);
        }
        System.Console.WriteLine("Character created!");
    }
}