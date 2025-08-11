namespace OnlineOrdering;

public record class Customer(string Name, Address Address)
{
    public bool IsInternational => Address.IsInternational;
}
