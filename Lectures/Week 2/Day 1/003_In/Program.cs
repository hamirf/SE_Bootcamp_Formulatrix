class Program
{
    static void Main()
    {
        // In harus memiliki nilai awal
        int num = 2;
        int res = Method(num);
        Console.WriteLine(res);

        InMethod(in num);
        Console.WriteLine(num);
    }

    static int Method(int x)
    {
        return x + 7;
    }
    // Variabel In tidak bisa diubah
    // Variabel In bisa digunakan untuk perhitungan
    static void InMethod(in int x)
    {
        int y = x + 22;
        // x += 7;
        Console.WriteLine(y);
    }
}