using CheckersGame.Model;
using Microsoft.EntityFrameworkCore;


namespace Checkers_with_DB;

partial class Program
{
    static void ReadPlayersData()
    {
        using (Checkers db = new Checkers())
        {
            SectionTitle("Read Datas on Players Table");

            var players = db.Players?
                            .Include(p => p.Pieces);

            if (players == null || !players.Any())
            {
                Fail("No Players Found!");
                return;
            }

            Info($"ToQueryString: {players.ToQueryString()}"); // Print the Query
            foreach (var player in players)
            {
                Print($"Player {player.Name} with id {player.Id} has {player.Pieces.Count} Pieces");
            }
        }
    }

    static void ReadPositionsData()
    {
        using (Checkers db = new Checkers())
        {
            SectionTitle("Read Datas on Positions Table");

            var positions = db.Positions?
                              .Include(p => p.Pieces)
                              .Where(p => p.Row + p.Column >= 1);

            if (positions == null || !positions.Any())
            {
                Fail("No Positions Found!");
            }

            Info($"ToQueryString: {positions?.ToQueryString()}");
            foreach (var position in positions)
            {
                Print($"Row: {position.Row}, Column: {position.Column}. Piece count = {position.Pieces.Count}");
            }
        }
    }

    static void ReadRanksData()
    {
        using (Checkers db = new Checkers())
        {
            SectionTitle("Read Data on Ranks Table");

            var ranks = db.Ranks?
                          .Include(p => p.Pieces);

            if (ranks == null || !ranks.Any())
            {
                Fail("No Rank Found!");
                return;
            }

            Info($"ToQueryString: {ranks.ToQueryString}");
            foreach (var rank in ranks)
            {
                Print($"{rank.Name} id is {rank.Id}, and it has {rank.Pieces.Count} pieces");
            }
        }
    }

    static void ReadColorsData()
    {
        using (Checkers db = new Checkers())
        {
            SectionTitle("Read Datas on Colors Table");

            var colors = db.Colors?
                           .Include(p => p.Pieces);

            if (colors == null || !colors.Any())
            {
                Fail("No Color found!");
                return;
            }

            Info($"ToQueryString: {colors.ToQueryString()}");
            foreach (var color in colors)
            {
                Print($"{color.Name} with id {color.Id} has {color.Pieces.Count} pieces");
            }
        }
    }

    static void ReadPiecesData()
    {
        using (Checkers db = new Checkers())
        {
            SectionTitle("Read Datas on Pieces Table");

            var pieces = db.Pieces?
                           .Include(p => p.Player)
                           .Include(p => p.Position)
                           .Include(p => p.Rank)
                           .Include(p => p.Color);

            if (pieces == null || !pieces.Any())
            {
                Fail("No Piece Found!");
                return;
            }

            Info($"ToQueryString: {pieces.ToQueryString()}");
            foreach (var piece in pieces)
            {
                Print($"{piece.Id}. Piece with {piece.Position.Row},{piece.Position.Column} coordinate, {piece.Rank.Name} rank, and {piece.Color.Name} color is owned by {piece.Player?.Name}");
            }
        }
    }
}
