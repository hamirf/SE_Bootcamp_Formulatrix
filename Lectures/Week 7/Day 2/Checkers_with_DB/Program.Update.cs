using CheckersGame.Enum;
using CheckersGame.Model;
using Microsoft.EntityFrameworkCore;

namespace Checkers_with_DB;

partial class Program
{
    static void UpdatePlayersData()
    {
        using (Checkers db = new Checkers())
        {
            SectionTitle("========== Update Data on Players Table ==========");

            var players = db.Players?
                            .Include(p => p.Pieces);

            foreach (var player in players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}