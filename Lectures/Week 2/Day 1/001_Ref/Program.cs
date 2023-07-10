class Program
{
    static void Main()
    {
        // Ref harus memiliki nilai awal
        int num = 2;
        int res = Method(num);
        Console.WriteLine(res);

        RefMethod(num);
        Console.WriteLine(num);
    }

    static int Method(int x)
    {
        return x + 7;
    }
    // Variabel Ref bisa diubah ataupun tidak
    // Variabel Ref bisa juga digunakan untuk perhitungan
    static void OutMethod(ref int x)
    {
        return x + 7;
    }
}

// class Ref
// {

// }