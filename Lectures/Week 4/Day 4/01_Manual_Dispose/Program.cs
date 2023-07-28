using System.Runtime.InteropServices;
using System;
class Program
{
    static void Main()
    {
        House rumah1 = new("Venice");
        System.Console.WriteLine(rumah1.GetAddress());
        rumah1.Dispose();
        System.Console.WriteLine(rumah1.GetAddress());
        System.Console.WriteLine("---");

        using (House rumah2 = new("Dallas"))
        {
            System.Console.WriteLine(rumah2.GetAddress());
        }
    }
}
