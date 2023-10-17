using GeometryFigureArea;
using GeometryFigureAreaTests.TestCases;

namespace GeometryFigureAreaTests;

[TestFixture]
public class TriangleTests
{
    [Test]
    [TestCaseSource(typeof(TriangleTestCases), nameof(TriangleTestCases.WrongSideCountCases))]
    public void New_WrongSideCount_ThrowsArgumentException(double[] sides)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(sides), "Недопустимое количество сторон.");
    }

    [Test]
    [TestCaseSource(typeof(TriangleTestCases), nameof(TriangleTestCases.WrongSidesCases))]
    public void New_WrongSides_ThrowsArgumentException(double[] sides)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(sides), "Значения сторон треугольника некорректны.");
    }

    [Test]
    [TestCaseSource(typeof(TriangleTestCases), nameof(TriangleTestCases.SomeSidesBelowOrEqualZeroCases))]
    public void New_SomeSidesBelowOrEqualZero_ThrowsArgumentException(double[] sides)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(sides));
    }

    [Test]
    [TestCase(2, 3, 4, 2.9047375096555625)]
    [TestCase(6, 2, 7, 5.562148865321747)]
    [TestCase(6, 8, 10, 24)]
    public void GetArea_SidesAboveZero_ReturnsExpectedArea(double firstSide, double secondSide, double thirdSide, double expectedArea)
    {
        var triangle = new Triangle(firstSide, secondSide, thirdSide);
        var triangleArea = triangle.GetArea();

        Assert.That(triangleArea, Is.EqualTo(expectedArea));
    }
}

