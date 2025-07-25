using YouTubeVideos;

class Program
{
    static void Main()
    {
        User alice = new("Alice");
        User bob = new("Bob");
        User cart = new("Cart");
        User doug = new("Doug");

        Video[] videos = [
            new(
                "Game Development with ECS",
                cart,
                TimeSpan.FromMinutes(10),
                [
                    new(alice, "ECS is great!"),
                    new(bob, "This is too complicated for my brain"),
                    new(cart, "@Bob It's easier than it sounds!"),
                ]
            ),
            new(
                "C# in 10 Minutes",
                doug,
                TimeSpan.FromMinutes(10),
                [
                    new(alice, "nooooooooooooo use Rust instead"),
                    new(alice, "jk C# is great"),
                    new(bob, "This is... also too complicated for my brain"),
                ]
            ),
            new(
                "Python in 60 Seconds",
                doug,
                TimeSpan.FromSeconds(60),
                [
                    new(doug, "Remember to like and subscribe!"),
                    new(doug, "Also check out my video on C#"),
                    new(bob, "You know what, programming might not be for me"),
                ]
            ),
        ];

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author.Name}");
            Console.WriteLine($"Duration: {video.Duration}");
            Console.WriteLine($"Comments ({video.CommentCount}):");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"\t{comment}");
            }
            Console.WriteLine();
        }
    }
}