namespace _001_Object_As_Reference;

public class RAM
{
    public string? brand;
    public string? name;
    public int memSize;
    public int memSpeed;

    public RAM(string brand, string name, int memSize, int memSpeed)
    {
        this.brand = brand;
        this.name = name;
        this.memSize = memSize;
        this.memSpeed = memSpeed;
    }
}
