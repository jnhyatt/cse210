namespace ScriptureMemorizer;

public record class Word
{
    public Word(string text) => _text = text;

    private readonly string _text;
    public bool IsHidden { get; private init; } = false;

    public Word Hidden() => this with { IsHidden = true };

    public override string ToString() => IsHidden ? new string('_', _text.Length) : _text;
}