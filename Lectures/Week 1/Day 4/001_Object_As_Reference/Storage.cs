namespace _001_Object_As_Reference;

public class Storage
{
    public string? brand;
    public string? name;
    public string? type;
    public string? storageInterface;
    // public int seqRead;
    // public int seqWrite;
    public int storageSize;

    public Storage(string brand, string name, string type, string storageInterface, int storageSize)
    {
        this.brand = brand;
        this.name = name;
        this.type = type;
        this.storageInterface = storageInterface;
        this.storageSize = storageSize;
    }
}
