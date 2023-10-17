using GeometryFigureArea.Base;

namespace GeometryFigureArea;

/// <summary>
/// Предоставляет фнкционал фабрики создания геометрических фигур.
/// </summary>
public class FigureFactory : IFigureFactory
{
    /// <inheritdoc/>
    public IFigure CreateFigure(double radius)
    {
        return new Circle(radius);
    }

    /// <inheritdoc/>
    public IFigure CreateFigure(double firstSide, double secondSide, double thirdSide)
    {
        return new Triangle(firstSide, secondSide, thirdSide);
    }

    /// <inheritdoc/>
    public IFigure CreateFigure(IEnumerable<double> figureParams)
    {
        return figureParams.Count() switch
        {
            1 => new Circle(figureParams.ElementAt(0)),
            3 => new Triangle(figureParams),
            _ => throw new ArgumentException("Недопустимые параметры создаваемой фигуры.", nameof(figureParams)),
        };
    }
}

