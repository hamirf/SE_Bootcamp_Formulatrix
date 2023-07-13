class Program
{
    static void Main()
    {
        List<string> clientErrorLists = new List<string>();
        clientErrorLists.Add("Bad Request");
        clientErrorLists.Add("Unauthorized");
        clientErrorLists.Add("Payment Required");
        clientErrorLists.Add("Forbidden");
        clientErrorLists.Add("Not Found");

        int errorCode = 399;
        foreach (var clientError in clientErrorLists)
        {
            errorCode++;
            System.Console.WriteLine($"{errorCode} {clientError}");
        }
    }
}