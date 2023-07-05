using Vehicle;

class Program
{
    static void Main()
    {
        Kendaraan mobil = new Kendaraan();
        Kendaraan motor = new Kendaraan();

        mobil.jumlahRoda = 4;
        motor.jumlahRoda = 2;
        Console.WriteLine($"Jumlah Roda Mobil adalah {mobil.jumlahRoda}");
        Console.WriteLine($"Jumlah Roda Motor adalah {motor.jumlahRoda}");

        Console.WriteLine();

        Mobil yaris = new Mobil();
        Motor vespa = new Motor();

        yaris.kapasitasKursi = 5;
        yaris.warna = "Merah";

        vespa.stang = "Brembo";
        vespa.warna = "Merah Maroon";

        Console.WriteLine($"Kapasitas kursi sebanyak {yaris.kapasitasKursi}");
        Console.WriteLine($"Warna kendaraan {yaris.warna}");
        yaris.BelokKanan();
        yaris.Mundur();
        Console.WriteLine("=================================");
        Console.WriteLine($"Merk stangnya dari {vespa.stang}");
        Console.WriteLine($"Warna kendaraan {vespa.warna}");
        vespa.NyalaMesin();
        vespa.Cornering();
    }
}