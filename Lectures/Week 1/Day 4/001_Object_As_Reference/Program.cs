using _001_Object_As_Reference;

class Program
{
    static void Main()
    {
        Processor intel = new Processor();
        Motherboard gigabyte = new Motherboard();
        GraphicCard radeon = new GraphicCard();
        RAM corsair = new RAM();
        Storage kyo = new Storage();

        PersonalComputer myPC = new PersonalComputer(intel, gigabyte, radeon, corsair, kyo);
    }
}