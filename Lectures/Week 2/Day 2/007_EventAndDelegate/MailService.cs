namespace _007_EventAndDelegate;

public class MailService
{
    public void OnVideoEncoded(object sender, VideoEventArgs e)
    {
        Console.WriteLine($"MailService: {((VideoEncoder)sender).name} sending an email of encoded {e.Video.Title}...");
    }
}
