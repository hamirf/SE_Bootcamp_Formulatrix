using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string oriPath = @"..\Output File Origin";
        string destiPath = @"..\Output File Destination";

        Directory.CreateDirectory(oriPath);
        Directory.CreateDirectory(destiPath);

        string originPath = Path.Combine(oriPath, "Original Text.txt");
        string destinePath = Path.Combine(destiPath, "Destination Text.txt");

        // Write
        if (!File.Exists(originPath))
        {
            File.WriteAllText(originPath, "Hello, you are in the original file!\n");
            File.AppendAllText(originPath, "------------------------------------\n");
            File.AppendAllText(originPath, "Here, you can type anything you want\n");
            System.Console.WriteLine("File created");
        }

        // Read
        if (File.Exists(originPath))
        {
            string originFile = File.ReadAllText(originPath);
            System.Console.WriteLine(originFile);
        }

        // Copy
        if (File.Exists(originPath))
        {
            File.Copy(originPath, destinePath, true);
            System.Console.WriteLine("File copied");
        }

        // Read
        if (File.Exists(destinePath))
        {
            string destineFile = File.ReadAllText(destinePath);
            System.Console.WriteLine(destineFile);
        }

        // Delete
        if (File.Exists(originPath))
        {
            File.Delete(originPath);
            System.Console.WriteLine("File deleted");
        }
    }
}