using System.Text.Json.Serialization;

namespace EternalQuest;

class EternalGoal(string name, string description, int points) : Goal(name, description, points)
{
    public override int RecordEvent() => Points;

    [JsonIgnore]
    public override bool IsComplete => false;
    [JsonIgnore]
    public override string Status => "[∞]";
}