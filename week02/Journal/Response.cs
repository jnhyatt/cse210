namespace Journal;

public record class Response
{
    public string Prompt { get; init; } = "";
    public string Entry { get; init; } = "";
    public DateTime CreatedAt { get; init; } = DateTime.Now;

    public override string ToString() =>
        $"{CreatedAt}\nPrompt: {Prompt}\nEntry: {Entry}";

    public static Response FromPrompt(string prompt)
    {
        Console.WriteLine(prompt);
        string entry = Console.ReadLine();
        return new Response
        {
            Prompt = prompt,
            Entry = entry,
        };
    }
}
