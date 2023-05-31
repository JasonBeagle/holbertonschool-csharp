using System;

/// <summary> Matrix class </summary>
public class MatrixMath
{
    /// <summary> rotates 2d matrix by radians, returns result matrix </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            return new double[,] { { -1 } };
        }

        double[,] resultMatrix = new double[rows, cols];
        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double x = matrix[i, j];
                double y = matrix[j, rows - i - 1];
                resultMatrix[i, j] = x * cos - y * sin;
            }
        }

        return resultMatrix;
    }
}
