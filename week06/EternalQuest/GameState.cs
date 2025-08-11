using System.Text.Json.Serialization;

namespace EternalQuest;

public class GameState
{
    [JsonInclude]
    public List<Goal> Goals { get; private set; } = [];
    [JsonInclude]
    public int TotalPoints { get; private set; } = 0;

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        var points = Goals[goalIndex].RecordEvent();
        TotalPoints += points;
    }
}