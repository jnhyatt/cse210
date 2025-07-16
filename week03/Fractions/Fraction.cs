namespace Fractions;

class Fraction
{
    public int Numerator;
    public uint Denominator;

    public Fraction(int numerator, uint denominator = 1)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        Numerator = numerator;
        Denominator = denominator;
    }

    public override string ToString() => $"{Numerator}/{Denominator}";
    public double DecimalValue() => (double)Numerator / Denominator;
}
