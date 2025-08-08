namespace Mindfulness;

abstract class Activity
{
    public void Start()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Description);
        Console.Write("Enter duration (seconds): ");
        int durationSeconds = int.Parse(Console.ReadLine());

        Console.WriteLine("Starting...");
        PauseWithSpinner(3);

        RunActivity(durationSeconds);
        
        Console.WriteLine("Well done!");
        PauseWithSpinner(1);
        Console.WriteLine($"You completed {Name} for {durationSeconds} seconds.");
        PauseWithSpinner(3);
    }

    public static void PauseWithDots(int durationSeconds)
    {
        for (int i = 0; i < durationSeconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public static void PauseWithSpinner(int durationSeconds)
    {
        char[] spinner = { '-', '\\', '|', '/' };
        DateTime endTime = DateTime.Now.AddSeconds(durationSeconds);
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index % spinner.Length]);
            Thread.Sleep(200);
            Console.Write("\b");
            index++;
        }
        Console.Write(" ");
        Console.Write("\b");
    }

    public abstract string Name { get; }
    public abstract string Description { get; }
    protected abstract void RunActivity(int durationSeconds);
}
