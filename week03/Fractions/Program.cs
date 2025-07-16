class Program
{
    static void Main()
    {
        var fraction = new Fractions.Fraction(3, 2);
        Console.WriteLine(fraction); // Output: 3/1
        Console.WriteLine(fraction.DecimalValue()); // Output: 3.0
    }
}