using System.Globalization;

namespace Journal;

public record class Journal
{
    public List<Response> Entries { get; init; } = [];

    public override string ToString() => string.Join("\n", Entries);

    public void SaveTo(string filename)
    {
        using var writer = new StreamWriter(filename);
        using var csv = new CsvHelper.CsvWriter(writer, CultureInfo.InvariantCulture);
        csv.WriteRecords(Entries);
    }

    public static Journal LoadFrom(string filename)
    {
        using var reader = new StreamReader(filename);
        using var csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture);
        return new Journal { Entries = [.. csv.GetRecords<Response>()] };
    }
}