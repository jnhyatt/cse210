namespace ExerciseTracking;

public record class Running : Activity
{
    // Distance in km
    private readonly double distance;

    public Running(DateTime timestamp, TimeSpan duration, double distance) : base(timestamp, duration)
    {
        this.distance = distance;
    }

    public override double Speed => distance / Duration.TotalHours;
    public override string Name => "Running";
    public override double Distance => distance;
}
