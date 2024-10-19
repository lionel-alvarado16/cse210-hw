using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        // Comments of video 1
        List<Comments> commentsVideo1 = [
            new Comments("chopstick134", "Cleanest trailer ever. Hope to see this type of inovation in other devices too. Im looking forward and im excited"),
            new Comments("halo-halo9244", "Watching this on my 720p phone. It's so sharp I can see every detail."),
            new Comments("joshinglyyy", "proud to have this as my TV"),
            new Comments("phantomlm", "I have this TV and It's extremely fast and the ai upscaling looks amazing, I switch between Amazon prime and yt and it does it in like 2 seconds and I can't wait to connect my Xbox series s to it")
            ];

        // Comments of video 2
        List<Comments> commentsVideo2 = [
            new Comments("muzongooo", "This is why Sony has become the leader of the camera industry. Always pushing the limits: Eye AF, AI AF, and now Global Shutter!"),
            new Comments("Efficient7x", "Sony's implementation of a global shutter is truly a remarkable feat in the camera industry!"),
            new Comments("MrCoolAttitude", "As a Nikon shooter I'm always envious of Sony's technology innovations."),
            ];

        // Comments of video 3
        List<Comments> commentsVideo3 = [
            new Comments("itsaty7760", "Finally a rbg fridge, I hope next year Lg will design a rbg toaster that razer never delivered"),
            new Comments("Roadman1000", "Hopefully my appliance store chain gets one of these.  It would be a great center piece!"),
            new Comments("X-3K", "This has got to be the most Aperture Science Portal 2 style home appliance i have ever seen, where can i get one?"),
            new Comments("braden7272", "What's the dimensions of this fridge? Where can I buy it in Malaysia?")
            ];

        List<Video> videos = [
            new Video("2024 Neo QLED 8K: A New Era of Samsung AI TV", "Samsung", 169, commentsVideo1),
            new Video("Introducing Alpha 9 III - Sony - α", "Sony Camera Channel", 134, commentsVideo2),
            new Video("LG at CES 2024 : LG Refrigerator with MoodUP", "LG Global", 41, commentsVideo3)
            ];
        
        for (int i = 0; i < videos.Count; i++)
        {
            videos[i].DisplayVideo();
            Console.WriteLine();
        }
    }
}