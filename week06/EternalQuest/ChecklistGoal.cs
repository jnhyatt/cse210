using System.Text.Json.Serialization;

namespace EternalQuest;

public class ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) : Goal(name, description, points)
{
    [JsonInclude]
    public int CurrentCount { get; private set; } = 0;
    [JsonInclude]
    public int TargetCount { get; } = targetCount;
    [JsonInclude]
    public int BonusPoints { get; } = bonusPoints;

    public override int RecordEvent()
    {
        if (CurrentCount >= TargetCount)
            return 0;
        CurrentCount++;
        return Points + CurrentCount == TargetCount ? BonusPoints : 0;
    }

    [JsonIgnore]
    public override bool IsComplete => CurrentCount >= TargetCount;

    [JsonIgnore]
    public override string Status => $"[{CurrentCount}/{TargetCount}]";
}