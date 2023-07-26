using Checkers;

class Program
{
    static void Main()
    {
        Player player1 = new Player();
        Player player2 = new Player();
        for (int i = 1; i <= 2; i++)
        {
            string name;
            do
            {
                Console.WriteLine($"Enter Player {i} Name: ");
                name = Console.ReadLine();
            } while (name == null);

            if (i == 1)
            {
                player1.SetName(name);
                player1.SetID(i);
            }
            else
            {
                player2.SetName(name);
                player2.SetID(i);
            }

        }
    }
}