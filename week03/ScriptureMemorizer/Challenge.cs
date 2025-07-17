using System.Collections.Immutable;

namespace ScriptureMemorizer;

public record class Challenge
{
    public Challenge(Scripture scripture)
    {
        Words = [.. scripture.Words.Select(word => new Word(word))];
        _reference = scripture.Reference;
    }

    private ImmutableList<Word> Words { get; init; }
    private Reference _reference;

    /// <summary>
    /// Hides a random word from the scripture.
    /// </summary>
    /// <returns>
    /// A new instance of <see cref="Challenge"/> with an additional hidden word. If all words are
    /// already hidden, it returns null.
    /// </returns>
    public Challenge? WithRandomlyHiddenWord()
    {
        Random random = new();
        try
        {
            // Select a random index of a word that is not hidden.
            int nextHiddenIndex = Words.Select((word, i) => (word, i))
                .Where(pair => !pair.word.IsHidden)
                .Select(pair => pair.i)
                .OrderBy(_ => random.Next())
                .First();
            return this with
            {
                Words = Words.SetItem(nextHiddenIndex, Words[nextHiddenIndex].Hidden())
            };
        }
        catch (InvalidOperationException)
        {
            // `First` throws if all words are already hidden, so return `null` to indicate that the
            // user has memorized the scripture.
            return null;
        }
    }

    public override string ToString() => $"{_reference}:\n" + Words
        .Select(word => word.ToString())
        .Aggregate((current, next) => $"{current} {next}");
}