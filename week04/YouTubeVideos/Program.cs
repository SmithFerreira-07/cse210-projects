using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();


        Video videotutorial = new Video("Rust Beginner Tutorial", "Mr.Krabs", 300);
        videotutorial.AddComment(new Comment("Eric", "🦀🦀🦀🦀🦀."));
        videotutorial.AddComment(new Comment("Victor", "This video lacks information."));
        videotutorial.AddComment(new Comment("Joe Biden", "Can you make one about C ?"));


        Video videoreview = new Video("Andrei Rublev: Tarkovski Film Review", "Arthur", 500);
        videoreview.AddComment(new Comment("David Lynch", "Tarkovski is a Master Director!"));
        videoreview.AddComment(new Comment("Belá Tarr", "Egy remekmű"));
        videoreview.AddComment(new Comment("David Lean", "I prefer Lawrence of Arabia"));

        Video videotutorial2 = new Video("Linux Essentials", "Julian", 300);
        videotutorial2.AddComment(new Comment("Linus Torvald", "🐧🐧🐧🐧🐧"));
        videotutorial2.AddComment(new Comment("Richard Stallman", "🐂🐂🐂🐂🐂"));
        videotutorial2.AddComment(new Comment("Ken Thompson", "🖥️🖥️🖥️"));
        
    }
}