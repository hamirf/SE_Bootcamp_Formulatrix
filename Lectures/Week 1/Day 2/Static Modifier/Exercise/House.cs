namespace Luas_Rumah;

public class House
{
    public string type;
    public static int luasTanah;
    public int panjang;
    public int lebar;
    public int luasBangunan;

    public House(string type, int p, int l)
    {
        this.type = type;
        panjang = p;
        lebar = l;
        luasBangunan = panjang * lebar;
    }

    public static string luasKavling()
    {
        return $"Luas Kavling adalah {luasTanah}";
    }

    public string luasBangunanType()
    {
        // Console.WriteLine(luasTanah);
        // Console.WriteLine(luasBangunan);

        if (luasBangunan <= luasTanah)
        {
            return $"Rumah tipe {type} aman dari amukan warga";
        }
        else
        {
            return $"Rumah tipe {type} tidak aman dari amukan warga";
        }
    }
}
