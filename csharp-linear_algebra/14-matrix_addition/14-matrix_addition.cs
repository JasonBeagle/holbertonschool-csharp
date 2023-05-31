using System;
using System.Collections.Generic;
/// <summary> Matrix class
public class MatrixMath
{
    /// <summary> adds two matrices, returns result </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int rows2 = matrix2.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int cols2 = matrix2.GetLength(1);

        if ((rows1 != 2 && rows1 != 3) || rows1 != rows2 || cols1 != cols2)
        {
            return new double[,] { { -1 } };
        }

        double[,] resultMatrix = new double[rows1, cols1];
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return resultMatrix;
    }
}
