namespace YouTubeVideos;

public record Comment(User Author, string Content)
{
    public override string ToString() => $"{Author.Name}: {Content}";
}
