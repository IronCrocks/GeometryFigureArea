using GeometryFigureArea;
using GeometryFigureArea.Base;
using GeometryFigureAreaTests.TestCases;

namespace GeometryFigureAreaTests;

[TestFixture]
public class FigureFactoryTests
{
    IFigureFactory _figureFactory;

    [SetUp]
    public void Setup()
    {
        _figureFactory = new FigureFactory();
    }

    [Test]
    [TestCase(5)]
    [TestCase(2.2)]
    public void CreateFigure_RadiusAboveZero_CreateCircle(double radius)
    {
        var actual = _figureFactory.CreateFigure(radius);

        Assert.That(actual, Is.InstanceOf(typeof(Circle)));
    }

    [Test]
    [TestCase(2, 4, 5)]
    [TestCase(1, 5, 4.5)]
    public void CreateFigure_ThreeSidesAboveZero_CreateTriangle(double firstSide, double secondSide, double thirdSide)
    {
        var actual = _figureFactory.CreateFigure(firstSide, secondSide, thirdSide);

        Assert.That(actual, Is.InstanceOf(typeof(Triangle)));
    }

    [Test]
    [TestCaseSource(typeof(FigureFactoryTestCases), nameof(FigureFactoryTestCases.SingleParamCases))]
    public void CreateFigure_SingleParamAboveZero_CreateCircle(double[] figureParams)
    {
        var actual = _figureFactory.CreateFigure(figureParams);

        Assert.That(actual, Is.InstanceOf(typeof(Circle)));
    }

    [Test]
    [TestCaseSource(typeof(FigureFactoryTestCases), nameof(FigureFactoryTestCases.ThreeParamsCases))]
    public void CreateFigure_ThreeParamsAboveZero_CreateTriangle(double[] figureParams)
    {
        var actual = _figureFactory.CreateFigure(figureParams);

        Assert.That(actual, Is.InstanceOf(typeof(Triangle)));
    }

    [Test]
    [TestCaseSource(typeof(FigureFactoryTestCases), nameof(FigureFactoryTestCases.WrongParamCountCases))]
    public void CreateFigure_WrongParamCount_ThrowsArgumentException(double[] figureParams)
    {
        Assert.Throws<ArgumentException>(() => _figureFactory.CreateFigure(figureParams));
    }
}
