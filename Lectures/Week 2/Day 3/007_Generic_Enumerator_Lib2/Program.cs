using System.Collections;

class Program
{
    static void Main()
    {
        Vendor<int, string> asus = new(1, "Asus");
        Vendor<int, string> msi = new(2, "MSI");
        Vendor<int, string> gigabyte = new(3, "Gigabyte");
        Vendor<int, string> asrock = new(4, "Asrock");

        Vendors<int, string> vendors = new();
        vendors.AddVendor(asus);
        vendors.AddVendor(msi);
        vendors.AddVendor(gigabyte);
        vendors.AddVendor(asrock);

        foreach (Vendor<int, string> vendorLists in vendors)
        {
            System.Console.WriteLine(vendorLists.Name);
        }
        System.Console.WriteLine();

        IEnumerator enumerator = vendors.GetEnumerator();
        vendors.Reset();
        while (vendors.MoveNext())
        {
            System.Console.WriteLine(vendors.Currents);
        }
        // vendors.Reset();
    }
}