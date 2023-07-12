namespace _007_EventAndDelegate;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video() { Title = "First Video" };
        VideoEncoder videoEncoder = new VideoEncoder(); // Publisher
        MailService mailService = new MailService(); // Subscriber
        MessageService messageService = new MessageService(); // Subscriber

        videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
        videoEncoder.VideoEncoded += messageService.OnVideoEncoded;


        videoEncoder.Encode(video);
    }
}
