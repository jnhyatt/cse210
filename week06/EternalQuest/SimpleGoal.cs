using System.Text.Json.Serialization;

namespace EternalQuest;

public class SimpleGoal(string name, string description, int points) : Goal(name, description, points)
{
    [JsonInclude]
    public bool Complete { get; private set; } = false;

    public override int RecordEvent()
    {
        if (!Complete)
        {
            Complete = true;
            return Points;
        }
        return 0;
    }

    [JsonIgnore]
    public override bool IsComplete => Complete;
    [JsonIgnore]
    public override string Status => $"{(IsComplete ? "[X]" : "[ ]")}";
}