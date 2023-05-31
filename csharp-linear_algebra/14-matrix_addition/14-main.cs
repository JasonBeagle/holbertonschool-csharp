using System;

class Program
{
    static void Main()
    {
        // Test 2D matrix addition
        double[,] matrix2D_1 = { { 1, 2 }, { 3, 4 } };
        double[,] matrix2D_2 = { { 5, 6 }, { 7, 8 } };
        double[,] resultMatrix2D = MatrixMath.Add(matrix2D_1, matrix2D_2);

        Console.WriteLine("Result of 2D matrix addition:");
        PrintMatrix(resultMatrix2D);

        // Test 3D matrix addition
        double[,] matrix3D_1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        double[,] matrix3D_2 = { { 10, 11, 12 }, { 13, 14, 15 }, { 16, 17, 18 } };
        double[,] resultMatrix3D = MatrixMath.Add(matrix3D_1, matrix3D_2);

        Console.WriteLine("Result of 3D matrix addition:");
        PrintMatrix(resultMatrix3D);

        // Test invalid matrices
        double[,] invalidMatrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        double[,] invalidMatrix2 = { { 1, 2 }, { 3, 4 } };
        double[,] invalidResult = MatrixMath.Add(invalidMatrix1, invalidMatrix2);

        Console.WriteLine("Invalid matrix addition:");
        PrintMatrix(invalidResult);
    }

    static void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
