using System.Collections;

class Program
{
    static void Main()
    {
        Vendor asus = new Vendor(1, "Asus");
        Vendor msi = new Vendor(2, "MSI");
        Vendor gigabyte = new Vendor(3, "Gigabyte");
        Vendor asrock = new Vendor(4, "Asrock");

        Vendors vendors = new Vendors();
        vendors.AddVendor(asus);
        vendors.AddVendor(msi);
        vendors.AddVendor(gigabyte);
        vendors.AddVendor(asrock);

        foreach (Vendor vendorLists in vendors)
        {
            System.Console.WriteLine(vendorLists);
        }
        System.Console.WriteLine();

        IEnumerator enumerator = vendors.GetEnumerator();
        vendors.Reset();
        while (vendors.MoveNext())
        {
            System.Console.WriteLine(vendors.Current);
        }
        // vendors.Reset();
    }
}