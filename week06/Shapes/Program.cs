using Shapes;

class Program
{
    static void Main()
    {
        List<PaperCutout> shapes = [
            new PaperCutout(new Square(5.0), "Red"),
            new PaperCutout(new Rectangle(4.0, 6.0), "Blue"),
            new PaperCutout(new Circle(3.0), "Green"),
        ];
        foreach (var cutout in shapes)
        {
            Console.WriteLine($"Color: {cutout.Color}, Area: {cutout.Shape.Area}");
        }
    }
}