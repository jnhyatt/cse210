namespace ExerciseTracking;

public abstract record class Activity
{
    public Activity(DateTime timestamp, TimeSpan duration)
    {
        Timestamp = timestamp;
        Duration = duration;
    }

    public DateTime Timestamp { get; init; }
    public TimeSpan Duration { get; init; }

    public abstract string Name { get; }
    // Distance in km
    public abstract double Distance { get; }
    // Speed in km/h
    public abstract double Speed { get; }
    public double Pace => Duration.TotalMinutes / Distance;

    public string GetSummary() => $"{Timestamp:yyyy-MM-dd} {Name} ({Duration.TotalMinutes:F1} min): Distance {Distance:F2} km, Speed {Speed:F2} km/h, Pace {Pace:F2} min/km";
}