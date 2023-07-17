public class LaptopEventArgs : EventArgs
{
    public Laptop Laptop { get; set; }
    public string RepairDesc { get; set; }

    public LaptopEventArgs(Laptop laptop, string repairDesc)
    {
        Laptop = laptop;
        RepairDesc = repairDesc;
    }
}