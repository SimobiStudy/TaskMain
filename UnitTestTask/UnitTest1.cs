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
        Assert.That(TriangleCalculations.ValidateTriangle(tr), Is.True);
    }

    [TestCase(21, 13, 15, 96.7893976632)]
    [TestCase(9.4, 12.22, 6.3, 29.128232968)]
    public void ThreeSidesTriangleAreaTest(double a, double b, double c, double expected)
    {
        Assert.That(TriangleCalculations.GetTriangleArea(new Triangle(a,b,c)), Is.EqualTo(expected).Within(0.0001).Percent);
    }

    [TestCase(21, 13, 15, new double[] { 0.661797, 0.78819, 1.6916 })]
    public void TriangleAngleesTest(double a, double b, double c, double[] angleExpected)
    {
        var result = TriangleCalculations.GetTriangleAngles(new Triangle(a,b,c));
        for(int i = 0; i < 3; i++)
        {
            Assert.That(result[i], Is.EqualTo(angleExpected[i]).Within(0.001).Percent);
        }
        Assert.Pass();
    }

    [TestCase(21, 13, 15, new double[] {9.218, 14.890676, 12.905253 })]
    public void TriangleHeightsTest(double a, double b, double c, double[] heightsExpected)
    {
        var result = TriangleCalculations.GetTriangleHeights(new Triangle(a,b,c));
        for(int i = 0; i < 3; i++)
        {
            Assert.That(result[i], Is.EqualTo(heightsExpected[i]).Within(0.001).Percent);
        }
        Assert.Pass();
    }
}