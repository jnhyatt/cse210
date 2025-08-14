namespace ExerciseTracking;

public record class Cycling : Activity
{
    // Speed in km/h
    private readonly double speed;

    public Cycling(DateTime timestamp, TimeSpan duration, double speed) : base(timestamp, duration)
    {
        this.speed = speed;
    }

    public override double Speed => speed;
    public override string Name => "Cycling";
    public override double Distance => speed * Duration.TotalHours;
}
