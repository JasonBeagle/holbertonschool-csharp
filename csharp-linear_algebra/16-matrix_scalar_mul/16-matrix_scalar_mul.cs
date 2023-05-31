using System;
using System.Collections.Generic;
/// <summary> Matrix class </summary>
public class MatrixMath
{
    /// <summary> multiplies matrix by a scaler, returns result matrix </summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 2 && rows != 3)
        {
            return new double[,] { { -1 } };
        }

        double[,] resultMatrix = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[i, j] = matrix[i, j] * scalar;
            }
        }

        return resultMatrix;
    }
}
