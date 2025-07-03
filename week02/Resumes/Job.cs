namespace Resumes;

public record class Job
{
    public string JobTitle { get; init; }
    public string Company { get; init; }
    public int StartYear { get; init; }
    public int EndYear { get; init; }

    public override string ToString() => $"{JobTitle} at {Company} ({StartYear}-{EndYear})";
    public void Display() => Console.WriteLine(ToString());
}