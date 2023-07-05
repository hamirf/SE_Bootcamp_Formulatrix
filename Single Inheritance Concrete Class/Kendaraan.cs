namespace Vehicle;

public class Kendaraan
{
    public int jumlahRoda;
    public string warna = "Hitam";

    public void NyalaMesin()
    {
        Console.WriteLine("Mesin menyala!");
    }

    public void BelokKanan()
    {
        Console.WriteLine("Belok kanan");
    }

    public void BelokKiri()
    {
        Console.WriteLine("Belok kiri");
    }
}

public class Mobil : Kendaraan
{
    public int kapasitasKursi;

    public void Mundur()
    {
        Console.WriteLine("Mobil sedang mundur");
    }
}

public class Motor : Kendaraan
{
    public string stang = "Bawaan";

    public void Cornering()
    {
        Console.WriteLine("Gas cornering");
    }
}
