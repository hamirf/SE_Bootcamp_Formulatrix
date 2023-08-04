using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Position position = new Position() { Row = 0, Column = 1 };
        Rank basic = Rank.Basic;
        Color black = Color.Black;
        Piece pieceOne = new Piece(position, basic, black);
        List<Piece> pieces = new List<Piece>();
        pieces.Add(pieceOne);

        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Piece>));
        using (FileStream piecesJson = new FileStream("pieces.json", FileMode.OpenOrCreate))
        {
            serializer.WriteObject(piecesJson, pieces);
        }

        // deserialize
        List<Piece>? deserializedPieces;
        using (FileStream deserializedPiecesJson = new FileStream("pieces.json", FileMode.Open))
        {
            deserializedPieces = (List<Piece>?)serializer.ReadObject(deserializedPiecesJson);
        }

        foreach (var piece in deserializedPieces)
        {
            System.Console.WriteLine(piece.GetPosition());
            System.Console.WriteLine(piece.GetRank());
            System.Console.WriteLine(piece.GetColor());
        }
    }
}