using System.Text;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        StringBuilder sb = new();
        sb.Append("Hello ");
        sb.AppendLine("There!");
        sb.Append("C# ");
        sb.Append("Here");
        Console.WriteLine(sb);
        Console.WriteLine("-------------");

        sb.AppendFormat(" {0:C} ", 22);
        Console.WriteLine(sb);
        Console.WriteLine("-------------");

        sb.Insert(0, "Oy, ");
        Console.WriteLine(sb);
        Console.WriteLine("-------------");

        sb.Remove(15, 1);
        Console.WriteLine(sb);
        Console.WriteLine("-------------");

        sb.Replace("There", "Asuka");
        Console.WriteLine(sb);
        Console.WriteLine("-------------");

        int iterations = 100000;
        string resultString = "";
        StringBuilder resultStringBuilder = new StringBuilder();

        Stopwatch stopwatch1 = Stopwatch.StartNew();
        for (int i = 0; i < iterations; i++)
        {
            resultString += "a";
        }
        stopwatch1.Stop();

        Console.WriteLine($"Time String : {stopwatch1.ElapsedMilliseconds} ms");

        Stopwatch stopwatch2 = Stopwatch.StartNew();
        for (int i = 0; i < iterations; i++)
        {
            resultStringBuilder.Append("a");
        }
        stopwatch2.Stop();

        Console.WriteLine($"Time SB: {stopwatch2.ElapsedMilliseconds} ms");
    }
}