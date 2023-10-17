namespace GeometryFigureAreaTests.TestCases;

public class FigureFactoryTestCases
{
    public static double[][] SingleParamCases =
    {
        new double[] {5},
        new double[] {6}
    };

    public static double[][] ThreeParamsCases =
    {
        new double[] {2,3,4},
        new double[] {5,7,11}
    };

    public static double[][] WrongParamCountCases =
    {
        new double[] {5,7 },
        new double[] {6,7,6,9 }
    };
}

