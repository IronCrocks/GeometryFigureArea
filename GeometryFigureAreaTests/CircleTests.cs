using GeometryFigureArea;

namespace GeometryFigureAreaTests;

[TestFixture]
public class CircleTests
{
    [Test]
    [TestCase(0)]
    [TestCase(-5)]
    public void New_RadiusBelowOrEqualZero_ThrowsArgumentException(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }

    [Test]
    [TestCase(5, 78.5)]
    [TestCase(1, 3.14)]
    [TestCase(25, 1962.5)]
    public void GetArea_RadiusAboveZero_ReturnsExpectedArea(double radius, double expectedArea)
    {
        var circle = new Circle(radius);
        var circleArea = circle.GetArea();

        Assert.That(circleArea, Is.EqualTo(expectedArea));
    }
}

