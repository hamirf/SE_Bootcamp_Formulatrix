public delegate void ButtonClickEventHandler();

public class Button
{
    public event ButtonClickEventHandler ButtonClick;

    public void ClickAnyButton()
    {
        Console.WriteLine("Click any button ...");
    }

    public void StartButton()
    {
        ButtonClick();
    }
}

class Program
{
    static void Main()
    {
        Button button = new();

        button.ButtonClick += button.ClickAnyButton;
        button.StartButton();
        Console.ReadLine();

        button.ButtonClick -= button.ClickAnyButton;
        button.ButtonClick += OnButtonClick;
        button.StartButton();

        string y = Console.ReadLine();
        Console.WriteLine(y);
    }

    public static void OnButtonClick()
    {
        Console.WriteLine("On Button Clicked");
    }
}