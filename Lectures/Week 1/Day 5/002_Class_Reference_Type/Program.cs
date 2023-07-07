class Program
{
    static void Main()
    {
        Parent p = new(5);
        Parent c = p;

        c.x = 2;

        // Nilai p.x berubah, karena objek p merupakan ref type.
        // Ketika objek c sama dengan p, maka keduanya memiliki address yang sama
        // Walaupun ditumpukan yang berbeda pada stack
        Console.WriteLine(p.x);
        Console.WriteLine(c.x);
    }
}

class Parent
{
    public int x;

    public Parent(int x)
    {
        this.x = x;
    }
}