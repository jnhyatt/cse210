namespace Mindfulness;

class BreathingActivity : Activity
{
    public override string Name => "Breathing Activity";
    public override string Description =>
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    protected override void RunActivity(int durationSeconds)
    {
        var endTime = DateTime.Now.AddSeconds(durationSeconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            PauseWithDots(4);
            Console.Write("Breathe out...");
            PauseWithDots(8);
        }
    }
}
