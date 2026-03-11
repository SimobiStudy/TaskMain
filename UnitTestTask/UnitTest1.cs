using MainForm;

namespace UnitTestTask;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(2.2, 5.4, 7.1)]
    [TestCase(52, 44, 21)]
    public void ValidateTriangleTest(double a, double b, double c)
    {
        var tr = new Triangle(a, b, c);
        Assert.That(VariantTask.ValidateTriangle(tr), Is.True);
    }

    [TestCase(21, 13, 15, 96.7893976632)]
    [TestCase(9.4, 12.22, 6.3, 29.128232968)]
    public void ThreeSidesTriangleAreaTest(double a, double b, double c, double result)
    {
        Assert.That(TrianglePerimeter.GetTriangleArea(new Triangle(a,b,c)), Is.EqualTo(result).Within(0.0001).Percent);
    }
}