namespace GeometryFigureAreaTests.TestCases;

public class TriangleTestCases
{
    public static double[][] SomeSidesBelowOrEqualZeroCases =
    {
        new double[] {2,3,0},
        new double[] {0,3,4},
        new double[] {2,0,4},
        new double[] {0,0,0}
    };

    public static double[][] WrongSidesCases =
   {
        new double[] {2,3,5},
        new double[] {2,3,6},
        new double[] {5,12,5}
    };

    public static double[][] WrongSideCountCases =
    {
        new double[] {5,7 },
        new double[] {6,7,6,9 }
    };
}

