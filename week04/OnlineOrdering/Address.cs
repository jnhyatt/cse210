namespace OnlineOrdering;

public record Address(string StreetAddress, string City, string StateOrProvince, string Country)
{
    public bool IsInternational => Country != "USA";
    public override string ToString() => $"{StreetAddress}\n{City}, {StateOrProvince}\n{Country}";
}