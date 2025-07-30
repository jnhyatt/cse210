namespace Homework;

public abstract class Assignment(string studentName, string topic)
{
    private readonly string _studentName = studentName;
    private readonly string _topic = topic;

    public string GetSummary() => $"{_studentName} - {_topic}";
}