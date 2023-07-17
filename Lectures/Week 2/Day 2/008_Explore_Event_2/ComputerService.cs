public class ComputerService
{
    public string Name { get; } = "Hakai Komputer";

    public event EventHandler<LaptopEventArgs> ServiceCompleted;

    public void Service(Laptop laptop)
    {
        System.Console.WriteLine($"<<<<<<<<<<<<<<< Welcome to {Name} >>>>>>>>>>>>>>>");
        System.Console.WriteLine($"Repairing {laptop.LaptopName}..");

        LaptopEventArgs laptopEventArgs = new LaptopEventArgs(laptop, "Jack power short circuit");

        OnServiceCompleted(laptopEventArgs);
    }

    protected virtual void OnServiceCompleted(LaptopEventArgs e)
    {
        ServiceCompleted?.Invoke(this, e);
    }
}