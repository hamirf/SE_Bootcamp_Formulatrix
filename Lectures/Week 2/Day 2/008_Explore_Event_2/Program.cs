public class Program
{
    static void Main(string[] args)
    {
        Laptop asus = new Laptop("Asus K43SJ");
        ComputerService hakai = new ComputerService();
        Customer asuka = new Customer("Asuka", "Osaka");

        asuka.RegisteredCustomerLaptop(hakai);
        hakai.Service(asus);
        asuka.UnregisterCustomerLaptop(hakai);

        hakai.Service(new Laptop("Lenovo Thinkpad X280"));
    }
}