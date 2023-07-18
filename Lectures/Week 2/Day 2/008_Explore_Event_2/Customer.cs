public class Customer
{
    public string Name { get; set; }
    public string Address { get; set; }

    public Customer(string name, string address)
    {
        Name = name;
        Address = address;
    }

    public void ComputerServiceCompleted(object sender, LaptopEventArgs e)
    {
        System.Console.WriteLine($"===================== {((ComputerService)sender).Name} =====================");
        System.Console.WriteLine($"Repair Laptop {e.Laptop.LaptopName} Completed!");
        System.Console.WriteLine("Customer Detail: ");
        System.Console.WriteLine($"Name: {Name}, Address: {Address}");
        System.Console.WriteLine($"Repair Description: {e.RepairDesc}");
        System.Console.WriteLine($"===================== {((ComputerService)sender).Name} =====================");
    }

    public void RegisteredCustomerLaptop(ComputerService cs)
    {
        cs.ServiceCompleted += ComputerServiceCompleted;
    }

    public void UnregisterCustomerLaptop(ComputerService cs)
    {
        cs.ServiceCompleted -= ComputerServiceCompleted;
    }
}