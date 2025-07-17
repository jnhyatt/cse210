namespace ScriptureMemorizer;

/// Represents a reference to a scripture passage, such as "John 3:16". The reference can represent
/// multiple verses.
public record class Reference(string Book, int Chapter, int StartVerse, int? EndVerse = null)
{
    private string Verses => EndVerse is int endVerse
        ? $"{StartVerse}-{endVerse}"
        : $"{StartVerse}";

    public override string ToString() => $"{Book} {Chapter}:{Verses}";
}
