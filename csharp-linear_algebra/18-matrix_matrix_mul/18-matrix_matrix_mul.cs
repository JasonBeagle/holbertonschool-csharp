using System;
using System.Collections.Generic;
/// <summary> Matrix class </summary>
public class MatrixMath
{
    /// <summary> multiplies two matrices, returns result matrix </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if (cols1 != rows2)
        {
            return new double[,] { { -1 } };
        }

        double[,] resultMatrix = new double[rows1, cols2];
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                double sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }

        return resultMatrix;
    }
}
