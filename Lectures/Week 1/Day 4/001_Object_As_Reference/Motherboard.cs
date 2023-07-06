namespace _001_Object_As_Reference;

public class Motherboard
{
    public string? vendor;
    public string? series;
    public string? socket;

    public Motherboard(string vendor, string series, string socket)
    {
        this.vendor = vendor;
        this.series = series;
        this.socket = socket;
    }
}
