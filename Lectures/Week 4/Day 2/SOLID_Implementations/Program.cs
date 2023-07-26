class Program
{
    static void Main()
    {
        StandardKeyboard standardKeyboard = new();
        StandardMonitor standardMonitor = new();
        Dictionary<StandardKeyboard, StandardMonitor> standardComp = new();
        Windows98Machine windows98MachineStandard = new Windows98Machine(standardKeyboard, standardMonitor);
        bool isTKL = windows98MachineStandard.Keyboard.IsTenKeyLessVersion(true);
        bool isBL = windows98MachineStandard.Monitor.IsBezelLess(false);
        System.Console.WriteLine(isTKL);
        System.Console.WriteLine(isBL);
    }
}
