using _001_Object_As_Reference;

class Program
{
    static void Main()
    {
        Processor intel = new("Intel", 14, 20);
        Motherboard gigabyte = new("Gigabyte", "Z690", "LGA1700");
        GraphicCard radeon = new("AMD Radeon", "Gigabyte", "RX 6900 XT", 16);
        RAM corsair = new("Corsair", "Vengeance Pro RGB", 16, 3600);
        Storage kyo = new("Kyo", "Ultimate", "M.2 NVME SSD", "PCIe Gen4", 512);

        PersonalComputer myPC = new(intel, gigabyte, radeon, corsair, kyo);
        myPC.ProcessorDetail();
        Console.WriteLine("---------------------------------------------------");
        myPC.MotherboardDetail();
        Console.WriteLine("---------------------------------------------------");
        myPC.GraphicCardDetail();
        Console.WriteLine("---------------------------------------------------");
        myPC.RAMDetail();
        Console.WriteLine("---------------------------------------------------");
        myPC.StorageDetail();
    }
}