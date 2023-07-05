namespace Graphic_Card_Detail;

public class Graphic_Card
{
    public string name;
    public int power;
    public int minPSU;

    private bool _aV1EncodeSupp;

    public Graphic_Card(string name)
    {
        this.name = name;
    }

    public Graphic_Card(string name, int power, int minPSU)
    {
        this.name = name;
        this.power = power;
        this.minPSU = minPSU;
    }
    public Graphic_Card(string name, int power, int minPSU, bool aV1Encode)
    {
        this.name = name;
        this.power = power;
        this.minPSU = minPSU;
        _aV1EncodeSupp = aV1Encode;
    }

    public string GetAV1Encode()
    {
        string aV1Encode;

        if (_aV1EncodeSupp)
        {
            aV1Encode = $"{name} support AV1 Encode";
        }
        else
        {
            aV1Encode = $"{name} doesn't support AV1 Encode";
        }
        return aV1Encode;
    }

    public bool SetAV1Encode(bool aV1EncodeSupp)
    {
        if (aV1EncodeSupp)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Stock()
    {
        Console.WriteLine("Ready Stock");
    }

    public void TDP(int power)
    {
        Console.WriteLine($"{name} has TDP around {power} W");
    }

    public void TDP(int power, int minPSU)
    {
        Console.WriteLine($"{name} has TDP around {power} W, with minimum PSU recommendation {minPSU} W");
    }
}
