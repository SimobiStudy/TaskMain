using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;

namespace MainForm;


[SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
public class Triangle
{
    public double A { get; private set; }
    public double B { get; private set; }
    public double C { get; private set; }
    
    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public Triangle()
    {
        A = 1;
        B = 1;
        C = 1;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Triangle triangle)
            return A == triangle.A && B == triangle.B && C == triangle.C;
        else return false;
    }

    protected bool Equals(Triangle other)
    {
        return A == other.A && B == other.B && C == other.C;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(A, B, C);
    }
}