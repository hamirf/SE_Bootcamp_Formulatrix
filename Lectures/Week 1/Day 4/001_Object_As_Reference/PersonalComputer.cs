namespace _001_Object_As_Reference;

public class PersonalComputer
{
    public Processor processor;
    public Motherboard motherboard;
    public GraphicCard graphicCard;
    public RAM ram;
    public Storage storage;

    public PersonalComputer(Processor processor, Motherboard motherboard, GraphicCard graphicCard, RAM ram, Storage storage)
    {
        this.processor = processor;
        this.motherboard = motherboard;
        this.graphicCard = graphicCard;
        this.ram = ram;
        this.storage = storage;
    }

    public void ProcessorDetail()
    {
        Console.WriteLine($"The processor is {processor.brand} with {processor.core} core and {processor.thread} thread");
    }

    public void MotherboardDetail()
    {
        Console.WriteLine($"The motherboard is {motherboard.vendor} {motherboard.series} series with {motherboard.socket} socket");
    }

    public void GraphicCardDetail()
    {
        Console.WriteLine($"The Graphic Card is {graphicCard.brand} {graphicCard.vendor} {graphicCard.series} {graphicCard.vRAM}GB");
    }

    public void RAMDetail()
    {
        Console.WriteLine($"The RAM is {ram.brand} {ram.name} {ram.memSize}GB with {ram.memSpeed}mHz clock speed");
    }

    public void StorageDetail()
    {
        Console.WriteLine($"The Storage is {storage.brand} {storage.name} {storage.type} {storage.storageInterface} {storage.storageSize}GB");
    }
}
