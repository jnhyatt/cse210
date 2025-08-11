using System.Text.Json.Serialization;

namespace EternalQuest;

[JsonDerivedType(typeof(SimpleGoal), "simple")]
[JsonDerivedType(typeof(ChecklistGoal), "checklist")]
[JsonDerivedType(typeof(EternalGoal), "eternal")]
public abstract class Goal(string name, string description, int points)
{
    public string Name { get; } = name;
    public string Description { get; } = description;
    public int Points { get; } = points;

    public abstract int RecordEvent();
    [JsonIgnore]
    public abstract bool IsComplete { get; }
    [JsonIgnore]
    public abstract string Status { get; }
}
