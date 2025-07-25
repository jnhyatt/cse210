namespace OnlineOrdering;

public record Customer(string Name, Address Address)
{
    public bool IsInternational => Address.IsInternational;
}
