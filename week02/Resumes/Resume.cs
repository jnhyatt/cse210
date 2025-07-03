namespace Resumes;

public record class Resume
{
    public string Name { get; init; }
    public List<Job> Jobs { get; init; }

    public void Display() => Console.WriteLine($"Name: {Name}\nJobs:\n{string.Join("\n", Jobs)}");
}
