class Program
{
    static void Main()
    {
        // Out tidak harus memiliki nilai awal
        // int num;
        // int res = Method(num);
        // Console.WriteLine(res);

        OutMethod(out int num);
        Console.WriteLine(num);
    }

    static int Method(int x)
    {
        return x + 7;
    }
    // Variabel Out harus memiliki output
    // Variabel Ref bisa juga digunakan untuk perhitungan
    static void OutMethod(out int x)
    {
        x = 7;
    }
}

// class Ref
// {

// }