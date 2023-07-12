class Program
{
    static void Main()
    {
        // Ref harus memiliki nilai awal
        int num = 2;
        int res = Method(num);
        Console.WriteLine(res);

        RefMethod(ref num);
        Console.WriteLine(num);

        res = Method(num);
        Console.WriteLine(res);
    }

    static int Method(int x)
    {
        return x + 7;
    }
    // Variabel Ref bisa diubah ataupun tidak
    // Variabel Ref bisa juga digunakan untuk perhitungan
    static void RefMethod(ref int x)
    {
        x += 7;
    }
}

// class Ref
// {

// }