using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();


        Video videotutorial = new Video("Rust Beginner Tutorial", "Mr.Krabs", 300);
        videotutorial.AddComment(new Comment("Eric", "test"));
        videotutorial.AddComment(new Comment("Victor", "This video lacks information."));
        videotutorial.AddComment(new Comment("Joe Biden", "Can you make one about C ?"));
        videos.Add(videotutorial);


        Video videoreview = new Video("Andrei Rublev: Tarkovski Film Review", "Arthur", 500);
        videoreview.AddComment(new Comment("David Lynch", "Tarkovski is a Master Director!"));
        videoreview.AddComment(new Comment("Belá Tarr", "Egy remekmű"));
        videoreview.AddComment(new Comment("David Lean", "I prefer Lawrence of Arabia"));
        videos.Add(videoreview);

        Video videotutorial2 = new Video("Linux Essentials", "Julian", 300);
        videotutorial2.AddComment(new Comment("Linus Torvald", "🐧🐧🐧🐧🐧"));
        videotutorial2.AddComment(new Comment("Richard Stallman", "🐂🐂🐂🐂"));
        videotutorial2.AddComment(new Comment("Ken Thompson", "🖥️🖥️🖥️🖥️"));
        videos.Add(videotutorial2);


        foreach (var video in videos)
        {
            Console.WriteLine("Video Details:");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetComments()}");
            Console.WriteLine("Comments:");

             foreach (var comment in video.GetAllComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }

        
    }
}