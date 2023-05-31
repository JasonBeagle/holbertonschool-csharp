using System;
/// <summary> Matrix class </summary>
public class MatrixMath
{
    /// <summary> calculates inverse of 2d matrix </summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        if (rows != 2 || columns != 2)
        {
            return new double[,] { { -1 } };
        }

        double determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        if (determinant == 0)
        {
            return new double[,] { { -1 } };
        }

        double[,] inverse = new double[2, 2];
        inverse[0, 0] = matrix[1, 1] / determinant;
        inverse[0, 1] = -matrix[0, 1] / determinant;
        inverse[1, 0] = -matrix[1, 0] / determinant;
        inverse[1, 1] = matrix[0, 0] / determinant;

        return inverse;
    }
}
