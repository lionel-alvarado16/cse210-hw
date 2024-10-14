using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        // Comments of video 1
        List<Comments> commentsVideo1 = [
            new Comments("gatonator.", "The song of quarantine Time"),
            new Comments("antonikarbowski79", "Still makes me cry now at 45yrs old."),
            new Comments("Yoongs_Tangerine", "How is this not viral? Listening to this till 2024"),
            new Comments("nqtduc", "I love how each different generation has varied vibes of songs. Music is so unique that makes it beautiful and never boring")
            ];

        // Comments of video 2
        List<Comments> commentsVideo2 = [
            new Comments("cliffbehum-nd2lp", "It's March 12, 2024 and I just found out that Eric Carmen died. Part of My youth in Cleveland. Rest in peace."),
            new Comments("yukkaplant1", "So sad to hear the news.... such a talent. It's horrible reaching that age where voices from your youth are being lost so often."),
            new Comments("tammyblalock3694", "I'm very lonely right now but Jesus is with me"),
            ];

        List<Video> videos = [
            new Video("Close to you", "Carpenters", 273, commentsVideo1),
            new Video("All By My Self", "Eric Carmen", 300, commentsVideo2)
            ];
        
        for (int i = 0; i < videos.Count; i++)
        {
            videos[i].DisplayVideo();
            Console.WriteLine();
        }
    }
}