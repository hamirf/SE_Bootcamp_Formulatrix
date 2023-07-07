class Program
{
    static void Main()
    {
        // Akurasi kurang bagus
        double a = 2.1;
        double b = 2.2;

        float c = 3.3f;
        float d = 3.4f;

        // Best akurasi atau ketepatan
        decimal e = 4.5M;
        decimal f = 4.6M;

        if (a + b == 4.3)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }

        if (c + d == 6.7f)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }

        if (e + f == 9.1M)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}