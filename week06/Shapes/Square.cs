namespace Shapes;

public record class Square(double SideLength) : IShape
{
    public double Area => SideLength * SideLength;
}
