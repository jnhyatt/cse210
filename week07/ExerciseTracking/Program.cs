using ExerciseTracking;

class Program
{
    static void Main()
    {
        List<Activity> activities =
        [
            new Running(DateTime.Now, TimeSpan.FromMinutes(30), 5),
            new Cycling(DateTime.Now, TimeSpan.FromMinutes(60), 20),
            new Swimming(DateTime.Now, TimeSpan.FromMinutes(45), 30)
        ];

        foreach (var activity in activities)
        {
            Console.WriteLine($"{activity.GetSummary()}");
        }
    }
}