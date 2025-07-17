// My unique addition to the assignment is to add a library of scriptures that the user can choose
// from.

using ScriptureMemorizer;

class Program
{
    static void Main()
    {
        List<Scripture> scriptures = [
            new(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new(new Reference("Matthew", 6, 24), "No man can serve two masters: for either he will hate the one, and love the other; or else he will hold to the one, and despise the other. Ye cannot serve God and mammon.")
        ];

        foreach ((Reference reference, int i) in scriptures.Select((scripture, i) => (scripture.Reference, i + 1)))
        {
            Console.WriteLine($"{i}. {reference}");
        }
        Console.WriteLine("Which scripture would you like to memorize?");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > scriptures.Count)
        {
            Console.WriteLine("Invalid choice. Please enter a valid number.");
        }

        Challenge challenge = new(scriptures[choice - 1]);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Press enter to hide a word. Type 'quit' to exit.");
            Console.WriteLine(challenge);
            if (Console.ReadLine()?.Trim().ToLower() == "quit")
            {
                return;
            }
            if (challenge.WithRandomlyHiddenWord() is not Challenge newChallenge)
            {
                break;
            }
            challenge = newChallenge;
        }
        Console.WriteLine("You did it!");
    }
}