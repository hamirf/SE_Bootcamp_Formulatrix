using Graphic_Card_Detail;

namespace Main_Program;

public class Program
{
    static void Main()
    {
        Graphic_Card xt6900 = new Graphic_Card("Gigabyte Radeon RX 6900 XT 16GB Aorus Xtreme Waterforce WB");
        xt6900.power = 300;
        xt6900.Stock();
        xt6900.TDP(xt6900.power);
        string aV1EncoderSupport = xt6900.GetAV1Encode();
        Console.WriteLine(aV1EncoderSupport);
    }
}
