using GeometryFigureArea.Base;

namespace GeometryFigureArea;

/// <summary>
/// Предоставляет функционал треугольника.
/// </summary>
public class Triangle : IFigure
{
    private readonly IEnumerable<double> _sides;

    public Triangle(IEnumerable<double> sides)
    {
        if (sides is null)
        {
            throw new ArgumentNullException(nameof(sides));
        }
        if (sides.Count() != 3)
        {
            throw new ArgumentException("Недопустимое количество сторон.", nameof(sides));
        }
        if (!sides.All(p => p > 0))
        {
            throw new ArgumentException("Все стороны треугольника должны быть больше нуля", nameof(sides));
        }
        if (!IsSidesValid(sides))
        {
            throw new ArgumentException("Значения сторон треугольника некорректны.");
        }

        _sides = sides;
    }

    public Triangle(double firstSide, double secondSide, double thirdSide) : this(new double[] { firstSide, secondSide, thirdSide })
    {
    }

    /// <summary>
    /// Возвращает длину первой стороны треугольника.
    /// </summary>
    public double FirstSide => _sides.ElementAt(0);

    /// <summary>
    /// Возвращает длину второй стороны треугольника.
    /// </summary>
    public double SecondSide => _sides.ElementAt(1);

    /// <summary>
    /// Возвращает длину третьей стороны треугольника.
    /// </summary>
    public double ThirdSide => _sides.ElementAt(2);

    /// <inheritdoc/>
    public double GetArea()
    {
        return IsRectangular(out IEnumerable<double> legs) ? GetRectangularTriangleArea(legs) : GetCommonTriangleArea();
    }

    private bool IsSidesValid(IEnumerable<double> sides)
    {
        return sides.ElementAt(0) + sides.ElementAt(1) > sides.ElementAt(2) &&
            sides.ElementAt(0) + sides.ElementAt(2) > sides.ElementAt(1) &&
            sides.ElementAt(1) + sides.ElementAt(2) > sides.ElementAt(0);
    }

    private bool IsRectangular(out IEnumerable<double> legs)
    {
        double hypotenuse = GetHypotenuse();
        legs = GetLegs(hypotenuse);

        return Math.Pow(hypotenuse, 2) == Math.Pow(legs.ElementAt(0), 2) + Math.Pow(legs.ElementAt(1), 2);
    }

    private double GetHypotenuse() => _sides.Max();

    private IEnumerable<double> GetLegs(double hypotenuse)
    {
        var legs = _sides.ToList();
        legs.Remove(hypotenuse);

        return legs;
    }

    /// <summary>
    /// Вычисляет площадь прямоугольного треугольника.
    /// </summary>
    /// <returns>Площадь треугольника.</returns>
    private double GetRectangularTriangleArea(IEnumerable<double> legs)
    {
        return legs.ElementAt(0) * legs.ElementAt(1) * 0.5;
    }

    /// <summary>
    /// Вычисляет площадь треугольника в общем случае.
    /// </summary>
    /// <remarks>Производит вычисление по формуле Герона.</remarks>
    /// <returns>Площадь треугольника.</returns>
    private double GetCommonTriangleArea()
    {
        double semiperimeter = (FirstSide + SecondSide + ThirdSide) / 2;
        return Math.Sqrt(semiperimeter * (semiperimeter - FirstSide) * (semiperimeter - SecondSide) * (semiperimeter - ThirdSide));
    }
}
