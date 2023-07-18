class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Spider-Man: Homecoming Trailer", "Marvel", 120);
        video1.AddComment(new Comment("Stan", "That person who helps others simply because it should or must be done, and because it is the right thing to do, is indeed without a doubt, a real superhero."));
        video1.AddComment(new Comment("Lee", "Excelsior."));
        video1.AddComment(new Comment("Ethan", "I'm soo exited"));
        video1.AddComment(new Comment("Daena", "Stan Lee watches Marvel Trailers?"));

        Video video2 = new Video("World's Stongest Dude", "Dude Perfect", 840);
        video2.AddComment(new Comment("BondandBourne", "Cody was pulling the truck even when bleeding like crazy. That's dedication to competition, life and why I still love this channel after 14 years. These guys pour their heart and souls into making every video for us fans!"));
        video2.AddComment(new Comment("Xavierpng", "As a member of the fitness community, I've gotta say, this was awesome to watch! Love your content"));
        video2.AddComment(new Comment("TimeBucks", "Doing amazing as usual"));
        video2.AddComment(new Comment("samuraishadow", "Seeing Coby Beat the odds was incredible"));

        // Create a list of videos
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine(video.DisplayInfo());
        }
    }
}