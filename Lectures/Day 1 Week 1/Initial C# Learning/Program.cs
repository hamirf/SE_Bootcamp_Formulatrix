// See https://aka.ms/new-console-template for more information
namespace withClass;

public class Program
{
    static int myInt = 2;
    static string myString = "Hello String";
    public static void Main() {
        Console.WriteLine(myInt);
        Message();
        Display.theDisplay();
    }

    static void Message() {
        Console.WriteLine(myString);
    }
}