namespace ExerciseTracking;

public record class Swimming : Activity
{
    private readonly int laps;

    private const double LapDistance = 0.05; // 50 meters in km

    public Swimming(DateTime timestamp, TimeSpan duration, int laps) : base(timestamp, duration)
    {
        this.laps = laps;
    }

    public override double Speed => Distance / Duration.TotalHours;
    public override string Name => "Swimming";
    public override double Distance => laps * LapDistance;
}
