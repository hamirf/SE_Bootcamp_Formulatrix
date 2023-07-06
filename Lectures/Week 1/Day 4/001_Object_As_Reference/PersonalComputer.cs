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

}
