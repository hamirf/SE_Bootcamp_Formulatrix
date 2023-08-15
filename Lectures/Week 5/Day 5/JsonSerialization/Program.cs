using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Position position = new Position() { Row = 0, Column = 1 };
        Rank basic = Rank.Basic;
        Color black = Color.Black;
        Piece pieceOne = new Piece(position, basic, black);
        Piece pieceTwo = new Piece(new Position() { Row = 0, Column = 3 }, basic, black);
        List<Piece> pieces = new List<Piece>
        {
            pieceOne,
            pieceTwo
        };

        // DataContractJsonSerializerSettings jsonSettings = new DataContractJsonSerializerSettings
        // {
        //     UseSimpleDictionaryFormat = true

        // };

        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Piece>));
        // FileStream stream = new FileStream("pieces.json", FileMode.OpenOrCreate);
        // using (var jsonWriter = JsonReaderWriterFactory.CreateJsonWriter(stream, Encoding.UTF8, true, true, "\t"))
        // {
        //     serializer.WriteObject(jsonWriter, pieces);
        //     jsonWriter.Flush();
        // }

        // deserialize
        List<Piece> deserializedPieces;
        using (FileStream deserializedPiecesJson = new FileStream("pieces.json", FileMode.OpenOrCreate))
        {
            deserializedPieces = (List<Piece>)serializer.ReadObject(deserializedPiecesJson);
        }

        foreach (var piece in deserializedPieces)
        {
            System.Console.WriteLine(piece.GetPosition().Row + "," + piece.GetPosition().Column);
            System.Console.WriteLine(piece.GetRank());
            System.Console.WriteLine(piece.GetColor());
            System.Console.WriteLine();
        }
    }
}