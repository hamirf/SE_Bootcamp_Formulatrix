class Program
{
    static void Main()
    {
        string x = "5";
        string y = x;
        y = "2";

        // String merupakan class reference type, tetapi dia immutable.
        // Sehingga data tidak berubah ketika instance sudah dibuat.
        Console.WriteLine(x);
        Console.WriteLine(y);
    }
}