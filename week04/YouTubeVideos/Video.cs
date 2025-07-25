namespace YouTubeVideos;

public record Video(string Title, User Author, TimeSpan Duration, List<Comment> Comments)
{
    public int CommentCount => Comments.Count;
}
