namespace _007_EventAndDelegate;

public class MessageService
{
    public void OnVideoEncoded(object sender, VideoEventArgs e)
    {
        Console.WriteLine($"MessageService: {((VideoEncoder)sender).name} sending a text message of encoded {e.Video.Title}...");
    }
}