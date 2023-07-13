using System.Collections;

class Program
{
    static void Main()
    {
        int[] code = { 400, 401, 402, 403, 404 };

        IEnumerator enumerator = code.GetEnumerator();
        while (enumerator.MoveNext())
        {
            System.Console.WriteLine(enumerator.Current);
        }

        System.Console.WriteLine();
        enumerator.Reset();
        System.Console.WriteLine("Enumeration has been reset");
        System.Console.WriteLine();

        for (int i = code.Length - 1; i >= 0; i--)
        {
            System.Console.WriteLine(code[i]);
        }
    }
}