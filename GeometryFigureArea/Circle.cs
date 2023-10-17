using GeometryFigureArea.Base;

namespace GeometryFigureArea;

/// <summary>
/// Предоставляет функционал окружности.
/// </summary>
public class Circle : IFigure
{
    private readonly double Pi = 3.14;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Радиус окружности должен быть больше нуля.", nameof(radius));
        }

        Radius = radius;
    }

    /// <summary>
    /// Возвращает радиус окружности.
    /// </summary>
    public double Radius { get; }

    /// <inheritdoc/>
    public double GetArea()
    {
        return Pi * Math.Pow(Radius, 2);
    }
}
