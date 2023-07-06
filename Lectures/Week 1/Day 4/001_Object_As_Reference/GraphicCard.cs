namespace _001_Object_As_Reference;

public class GraphicCard
{
    public string? brand;
    public string? vendor;
    public string? series;
    public int vRAM;

    public GraphicCard(string brand, string vendor, string series, int vRAM)
    {
        this.brand = brand;
        this.vendor = vendor;
        this.series = series;
        this.vRAM = vRAM;
    }
}
