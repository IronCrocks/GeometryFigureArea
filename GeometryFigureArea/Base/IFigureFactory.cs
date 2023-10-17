namespace GeometryFigureArea.Base;

/// <summary>
/// Предоставляет базовый функционал фабрики геометрических фигур.
/// </summary>
public interface IFigureFactory
{
    /// <summary>
    /// Создает геометрическую фигуру.
    /// </summary>
    /// <param name="radius">Радиус фигуры.</param>
    /// <returns>Геометрическая фигура.</returns>
    public IFigure CreateFigure(double radius);

    /// <summary>
    /// Создает геометрическую фигуру.
    /// </summary>
    /// <param name="firstSide">Первая сторона фигуры.</param>
    /// <param name="secondSide">Вторая сторона фигуры.</param>
    /// <param name="thirdSide">Третья сторона фигуры.</param>
    /// <returns>Геометрическая фигура.</returns>
    public IFigure CreateFigure(double firstSide, double secondSide, double thirdSide);

    /// <summary>
    /// Создает геометрическую фигуру.
    /// </summary>
    /// <param name="figureParams">Параметры создаваемой фигуры.</param>
    /// <returns>Геометрическая фигура.</returns>
    public IFigure CreateFigure(IEnumerable<double> figureParams);
}

