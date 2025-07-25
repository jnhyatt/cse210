using OnlineOrdering;

class Program
{
    static void Main()
    {
        Product pistonRing = new("Piston Ring", 712307581, 5.99m);
        Product sparkPlug = new("Spark Plug", 338933843, 2.99m);
        Product oilFilter = new("Oil Filter", 739998263, 16.49m);
        Product cylinderHeadGasket = new("Cylinder Head Gasket", 663958396, 45.00m);
        Product mousePad = new("Mouse Pad", 872947622, 1.99m);
        Customer alice = new("Alice Cecile", new Address(
            "123 Maple St",
            "Toronto",
            "ON",
            "Canada"
        ));
        Customer bob = new("Bob Smith", new Address(
            "198 S Main St",
            "Logan",
            "UT",
            "USA"
        ));
        List<Order> orders = [
            new Order(alice, [
                new Order.ProductEntry(sparkPlug, 1),
                new Order.ProductEntry(oilFilter, 1),
                new Order.ProductEntry(mousePad, 1),
            ]),
            new Order(bob, [
                new Order.ProductEntry(pistonRing, 6),
                new Order.ProductEntry(sparkPlug, 6),
                new Order.ProductEntry(cylinderHeadGasket, 1),
            ]),
        ];

        foreach (Order order in orders)
        {
            Console.WriteLine("New order:");
            Console.WriteLine(order.PackingLabel);
            Console.WriteLine();
            Console.WriteLine(order.ShippingLabel);
            Console.WriteLine($"Total due: {order.TotalPrice:C}");
            Console.WriteLine();
        }
    }
}