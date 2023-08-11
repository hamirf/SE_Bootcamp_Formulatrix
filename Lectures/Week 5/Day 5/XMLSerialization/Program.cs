using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

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

        // Xml Settings
        XmlWriterSettings settings = new XmlWriterSettings();
        settings.Indent = true;
        settings.NewLineOnAttributes = true;

        // serializer
        DataContractSerializer serializer = new DataContractSerializer(typeof(List<Piece>));
        using (XmlWriter pieceWriter = XmlWriter.Create("pieces.xml", settings))
        {
            serializer.WriteObject(pieceWriter, pieces);
        }

        // deserializer
        List<Piece>? deserializedPieces;
        FileStream fs = new FileStream("pieces.xml", FileMode.Open);
        using (XmlDictionaryReader pieceReader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas()))
        {
            deserializedPieces = (List<Piece>?)serializer.ReadObject(pieceReader);
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