namespace ScriptureMemorizer;

public record class Scripture
{
    public Reference Reference { get; init; }
    public List<string> Words { get; init; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = [.. text.Split(' ')];
    }
}
