namespace Shapes;

public record class Rectangle(double Width, double Height) : IShape
{
    public double Area => Width * Height;
}
