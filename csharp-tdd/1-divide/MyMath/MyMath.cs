using System;

namespace MyMath
{
    public class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            if (matrix != null)
            {
                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);

                int[,] dividedMatrix = new int[rows, columns];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dividedMatrix[i, j] = matrix[i, j] / num;
                    }
                }

                return dividedMatrix;
            }

            return null;
        }
    }
}