namespace OnlineOrdering;

public record class Order(Customer Customer, List<Order.ProductEntry> Items)
{
    public record class ProductEntry(Product Product, int Quantity)
    {
        public decimal TotalPrice => Product.Price * Quantity;
    }

    public decimal ShippingCost => Customer.IsInternational ? 35.00m : 5.00m;
    public decimal TotalPrice => Items.Sum(item => item.TotalPrice) + ShippingCost;
    public string ShippingLabel => $"{Customer.Name}\n{Customer.Address}";
    public string PackingLabel => string.Join("\n", Items.Select(item => $"{item.Quantity} x {item.Product.Name} ({item.Product.Price:C})"));
}
