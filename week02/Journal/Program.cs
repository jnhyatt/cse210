// My unique/creative addition is to prompt the user to save their entries before loading new ones
// to prevent accidental data loss.

using Journal;

class Program
{
    static readonly List<string> prompts = [
        "What was the best part of your day?",
        "Did you learn something new today?",
        "What are you grateful for?",
        "What challenges did you face today?",
        "What are your goals for tomorrow?"
    ];

    static void Main()
    {
        Journal.Journal journal = new();
        bool saved = true;
        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. View all entries");
            Console.WriteLine("3. Save entries");
            Console.WriteLine("4. Load entries");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input");
                continue;
            }
            switch (choice)
            {
                case 1:
                    var response = Response.FromPrompt(prompts[new Random().Next(prompts.Count)]);
                    journal = journal with { Entries = [.. journal.Entries, response] };
                    saved = false;
                    break;
                case 2:
                    Console.WriteLine(journal);
                    break;
                case 3:
                    {
                        Console.WriteLine("Enter filename to save entries (CSV): ");
                        journal.SaveTo(Console.ReadLine());
                        saved = true;
                        break;
                    }
                case 4:
                    {
                        if (!saved)
                        {
                            Console.WriteLine("You have unsaved changes. Do you want to save them first? (y/n)");
                            if (Console.ReadLine()?.ToLower() == "y")
                            {
                                Console.WriteLine("Enter filename to save entries (CSV): ");
                                journal.SaveTo(Console.ReadLine());
                                saved = true;
                            }
                        }
                        Console.WriteLine("Enter filename to load entries (CSV): ");
                        string filename = Console.ReadLine();
                        journal = Journal.Journal.LoadFrom(filename);
                        break;
                    }
                case 0: return;
            }
        }
    }
}