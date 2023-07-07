class Program
{
    static void Main()
    {
        int a = 5;
        int b = a;
        b = 2;

        // Nilai a tidak berubah, karena a dan b merupakan Struct (Value type).
        // Dimana ketika sudah dibuat maka data bisa diubah (mutable types);
        // Ketika b sama dengan a, b hanya menyamakan value nya dengan a
        // Tetapi keduanya berada pada memori yang berbeda, berada ditumpukan yang berbeda pada stack
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}