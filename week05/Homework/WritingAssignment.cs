namespace Homework;

public class WritingAssignment(string studentName, string topic, string title) : Assignment(studentName, topic)
{
    private readonly string _title = title;

    public string GetWritingInformation() => $"{GetSummary()}\n{_title}";
}