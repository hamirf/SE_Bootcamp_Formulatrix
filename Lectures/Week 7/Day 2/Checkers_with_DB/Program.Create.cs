using CheckersGame.Enum;
using CheckersGame.Model;

namespace Checkers_with_DB;

partial class Program
{
    static void CreatePlayersData()
    {
        using (Checkers db = new Checkers())
        {
            SectionTitle("========== Create New Data to Players Table ==========");

            string? name;
            bool isPlayerValid = false;
            bool isValid = false;
            do
            {
            InputName: Print("Enter Player Name: ");
                name = GetInput();

                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (name.ToLower().Contains(alphabet[i]))
                    {
                        isValid = true;
                        isPlayerValid = true;
                        break;
                    }
                }

                if (!isValid)
                {
                    Fail("Invalid name! Wrong name format.");
                    goto InputName;
                }

                var playerName = db.Players?.Where(p => p.Name == name);
                if (playerName == null || !playerName.Any())
                {
                    isPlayerValid = true;
                }
                else
                {
                    isPlayerValid = false;
                    Fail("Name already exists! Please try another name.");
                }
            } while (!isPlayerValid);

            Player player = new Player() { Name = name };

            db.Players?.Add(player);
            db.SaveChanges();

            Info("Player Added Successfully.");
        }
    }

    static void CreatePositionsData()
    {
        using (Checkers db = new Checkers())
        {
            SectionTitle("========== Create New Data on Positions Table ==========");

            string? rowStr;
            string? columnStr;
            int row;
            int column;
            bool isRow;
            bool isColumn;
            bool isPositionValid = false;
            bool isValid = false;

        Input: do
            {
            InputRow: Print("Enter row: ");
                rowStr = GetInput();

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (rowStr.Contains(numbers[i]))
                    {
                        isPositionValid = true;
                        isValid = true;
                        break;
                    }
                }

                int.TryParse(rowStr, out row);

                if (!isValid)
                {
                    Fail("Invalid row! Please input again between 0 - 9.");
                    goto InputRow;
                }
            } while (!isPositionValid);

            isPositionValid = false;
            isValid = false;

            do
            {
            InputColumn: Print("Enter column: ");
                columnStr = GetInput();

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (columnStr.Contains(numbers[i]))
                    {
                        isPositionValid = true;
                        isValid = true;
                        break;
                    }
                }

                int.TryParse(columnStr, out column);

                if (!isValid)
                {
                    Fail("Invalid column! Please input again between 0 - 9.");
                    goto InputColumn;
                }
            } while (!isPositionValid);

            var positions = db.Positions?.Where(p => p.Row == row && p.Column == column);
            if (positions != null || positions.Any())
            {
                Fail("Position already exists! Please try again.");
                goto Input;
            }

            Position position = new Position()
            {
                Row = row,
                Column = column
            };

            db.Positions?.Add(position);
            db.SaveChanges();

            Info("Position Added Successfully.");
        }
    }

    static void CreateRanksData()
    {
        using (Checkers db = new Checkers())
        {
            SectionTitle("========== Create New Data on Ranks Table ==========");

            string? pieceRank;
            bool isRankValid = false;
            bool isValid = false;

            do
            {
            InputRank: Print("Enter piece rank: ");
                pieceRank = GetInput();

                foreach (var rankVariant in Enum.GetNames(typeof(ERank)))
                {
                    if (pieceRank.ToLower().Equals(rankVariant.ToLower()))
                    {
                        isRankValid = true;
                        isValid = true;
                        break;
                    }
                }

                if (!isValid)
                {
                    Fail("Rank invalid! Please input rank either Basic or King!");
                    goto InputRank;
                }

                var ranks = db.Ranks?.Where(r => r.Variety == pieceRank);
                if (ranks == null || !ranks.Any())
                {
                    isRankValid = true;
                }
                else
                {
                    isRankValid = false;
                    isValid = false;
                    Fail("Rank already exists! Please Try Again.");
                    goto InputRank;
                }
            } while (!isRankValid);

            Rank rank = new Rank() { Variety = pieceRank };

            db.Ranks?.Add(rank);
            db.SaveChanges();

            Info("Rank Added Successfully.");
        }
    }

    static void CreateColorsData()
    {
        using (Checkers db = new Checkers())
        {
            SectionTitle("========== Create New Data on Colors Table ==========");

            string? pieceColor;
            bool isColorValid = false;
            bool isValid = false;

            do
            {
            InputColor: Print("Enter piece color: ");
                pieceColor = GetInput();
                foreach (var colorVariant in Enum.GetNames(typeof(EColor)))
                {
                    if (pieceColor.ToLower().Equals(colorVariant.ToLower()))
                    {
                        isColorValid = true;
                        isValid = true;
                        break;
                    }
                }

                if (!isValid)
                {
                    Fail("Color invalid! Please input either Black or Red.");
                    goto InputColor;
                }

                var colors = db.Colors?.Where(c => c.variety == pieceColor);
                if (colors == null || !colors.Any())
                {
                    isColorValid = true;
                }
                else
                {
                    isColorValid = false;
                    isValid = false;
                    Fail("Color already exists! Please input another color.");
                    goto InputColor;
                }
            } while (!isColorValid);

            Color color = new Color() { variety = pieceColor };

            db.Colors?.Add(color);
            db.SaveChanges();

            Info("Color Added Successfully.");
        }
    }

    static void CreatePiecesData()
    {
        using (Checkers db = new Checkers())
        {
            SectionTitle("========== Create New Data on Pieces Table ==========");

            int posId;
            int rankId;
            int colorId;
            int playerId;
            IQueryable<Position>? positions;
            IQueryable<Rank>? ranks;
            IQueryable<Color>? colors;
            IQueryable<Player>? players;

            do
            {
                positions = db.Positions?.OrderBy(p => p.Id).Distinct();
                Print("========== Id of Positions Table ==========");
                foreach (var position in positions)
                {
                    Print($"\tPositionId = {position.Id}");
                }
                Print("");
                Print("Enter existing PositionId: ");
                posId = Convert.ToInt32(GetInput());
                positions = db.Positions?.Where(p => p.Id == posId);
                if (positions.Count() == 0)
                {
                    Fail("PositionId doesn't exists!");
                }
            } while (positions == null);

            do
            {
                ranks = db.Ranks?.OrderBy(r => r.Id).Distinct();
                Print("========== Id of Ranks Table ==========");
                foreach (var rank in ranks)
                {
                    Print($"\tRankId: {rank.Id}");
                }
                Print("");
                Print("Enter existing RankId: ");
                rankId = Convert.ToInt32(GetInput());
                ranks = db.Ranks?.Where(r => r.Id == rankId);
            } while (ranks == null);

            do
            {
                colors = db.Colors?.OrderBy(c => c.id).Distinct();
                Print("========== Id of Colors Table ==========");
                foreach (var color in colors)
                {
                    Print($"\tColorId: {color.id}");
                }
                Print("Enter existing ColorId: ");
                colorId = Convert.ToInt32(GetInput());
                colors = db.Colors?.Where(c => c.id == colorId);
            } while (colors == null);

            do
            {
                players = db.Players?.OrderBy(p => p.Id).Distinct();
                Print("========== Id of Players Table ==========");
                foreach (var player in players)
                {
                    Print($"\tPlayersId: {player.Id}");
                }
                Print("Enter existing PlayerId: ");
                playerId = Convert.ToInt32(GetInput());
                players = db.Players?.Where(p => p.Id == playerId);
            } while (players == null);

            Piece piece = new Piece()
            {
                PositionId = posId,
                RankId = rankId,
                ColorId = colorId,
                PlayerId = playerId,
                IsEaten = 0,
                IsKinged = 0
            };

            db.Pieces?.Add(piece);
            db.SaveChanges();

            Info("Piece Added Successfully.");
        }
    }
}