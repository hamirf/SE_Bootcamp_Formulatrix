// using System.Threading;

// namespace _007_EventAndDelegateCopy;
// public class VideoEncoder // Publisher
// {
//     public string name = "Brando";
//     // 1. Define a delegate (Signature of a method) (Contract between the Publisher and Subscriber)
//     // Delegeta name convention => Event name (instance) + EventHandler
//     // public delegate void VideoEncodedEventHandler(object sender, VideoEventArgs e);

//     // 2. Define an event based on the delegate
//     public event EventHandler<VideoEventArgs> VideoEncoded;

//     public void Encoding(Video video)
//     {
//         VideoEncoded += EncodingVideo;

//         VideoEventArgs videoEventArgs = new VideoEventArgs(video);
//         OnVideoEncoded(videoEventArgs);
//         Thread.Sleep(2000);
//     }

//     public void Encode(Video video)
//     {
//         // Console.WriteLine($"Encoding {video.Title}...");
//         // Thread.Sleep(2000);

//         VideoEventArgs videoEventArgs = new VideoEventArgs(video);
//         // 5. Call the event once the Encode method finished
//         OnVideoEncoded(videoEventArgs);
//     }

//     public void EncodingVideo(object sender, VideoEventArgs e)
//     {
//         System.Console.WriteLine($"Encoding {e.Video.Title}...");
//     }
//     // 3. Raise or publish the event
//     // 4. Method to publish or notify the finished/completed event to the Subscriber
//     protected virtual void OnVideoEncoded(VideoEventArgs e)
//     {
//         if (VideoEncoded != null)
//         {
//             VideoEncoded?.Invoke(this, e);
//         }
//     }
// }
