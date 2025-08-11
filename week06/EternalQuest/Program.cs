using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using EternalQuest;

class Program
{
    static void Main()
    {
        GameState gameState = new();
        while (true)
        {
            Console.WriteLine($"Your score: {gameState.TotalPoints}");
            PrintGoals(gameState);
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Create a Simple Goal");
            Console.WriteLine("2. Create a Checklist Goal");
            Console.WriteLine("3. Create an Eternal Goal");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Record an Event");
            Console.WriteLine("7. Exit");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 7)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
            }
            switch (choice)
            {
                case 1:
                    {
                        var (name, description, points) = PromptGoalCommon();
                        gameState.Goals.Add(new SimpleGoal(name, description, points));
                        break;
                    }
                case 2:
                    {
                        var (name, checklistDescription, checklistPoints) = PromptGoalCommon();
                        Console.Write("Enter target count: ");
                        int targetCount = int.Parse(Console.ReadLine());
                        Console.Write("Enter bonus points: ");
                        int bonusPoints = int.Parse(Console.ReadLine());
                        gameState.Goals.Add(new ChecklistGoal(name, checklistDescription, checklistPoints, targetCount, bonusPoints));
                        break;
                    }
                case 3:
                    {
                        var (name, description, points) = PromptGoalCommon();
                        gameState.Goals.Add(new EternalGoal(name, description, points));
                        break;
                    }
                case 4:
                    File.WriteAllText("goals.json", JsonSerializer.Serialize(gameState));
                    break;
                case 5:
                    if (!File.Exists("goals.json"))
                    {
                        Console.WriteLine("No saved goals found.");
                        break;
                    }
                    string json = File.ReadAllText("goals.json");
                    gameState = JsonSerializer.Deserialize<GameState>(json);
                    break;
                case 6:
                    if (gameState.Goals.Count == 0)
                    {
                        Console.WriteLine("No goals available to record an event.");
                        break;
                    }
                    PrintGoals(gameState);
                    Console.Write("Which goal did you complete? ");
                    int goalIndex;
                    while (!int.TryParse(Console.ReadLine(), out goalIndex) || goalIndex < 1 || goalIndex > gameState.Goals.Count)
                    {
                        Console.WriteLine("Invalid goal number. Please try again.");
                    }
                    if (gameState.Goals[goalIndex - 1].IsComplete)
                    {
                        Console.WriteLine("This goal is already complete.");
                        break;
                    }
                    gameState.RecordEvent(goalIndex - 1);
                    Console.WriteLine($"You earned {gameState.Goals[goalIndex - 1].Points} points for completing the goal.");
                    if (gameState.Goals[goalIndex - 1].IsComplete)
                    {
                        Console.WriteLine("Congratulations! You have completed this goal.");
                    }
                    break;
                case 7:
                    return;
            }
        }
    }

    static (string name, string description, int points) PromptGoalCommon()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());
        return (name, description, points);
    }

    static void PrintGoals(GameState gameState)
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < gameState.Goals.Count; i++)
        {
            var goal = gameState.Goals[i];
            Console.WriteLine($"{goal.Status} {i + 1}. {goal.Name} - {goal.Description}");
        }
    }
}