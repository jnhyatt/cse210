namespace Shapes;

public record class Circle(double Radius) : IShape
{
    public double Area => Math.PI * Radius * Radius;
}
