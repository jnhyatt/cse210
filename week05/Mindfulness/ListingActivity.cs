namespace Mindfulness;

class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public override string Name => "Listing Activity";
    public override string Description =>
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    protected override void RunActivity(int durationSeconds)
    {
        var rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        Console.WriteLine("Get ready...");
        PauseWithDots(5);

        var endTime = DateTime.Now.AddSeconds(durationSeconds);
        var itemCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine($"You listed {itemCount} items!");
    }
}
