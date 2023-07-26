public class Windows98Machine
{

    private IKeyboard keyboard;
    private IMonitor monitor;
    Dictionary<IKeyboard, IMonitor> standardPC = new();

    public Windows98Machine(IKeyboard keyboard, IMonitor monitor)
    {
        this.Keyboard = keyboard;
        this.Monitor = monitor;
    }

    public IKeyboard Keyboard { get => keyboard; set => keyboard = value; }
    public IMonitor Monitor { get => monitor; set => monitor = value; }

    bool InitializeMachine(IKeyboard keyboard, IMonitor monitor)
    {
        if (keyboard != null && monitor != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}