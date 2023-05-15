using System;

public class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
	    int columns = myMatrix.GetLength(1);
        int rows = myMatrix.GetLength(0);
        
        int[,] newMatrix = new int[rows, columns];

        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                newMatrix[row, column] = myMatrix[row, column] * myMatrix[row, column];
            }
        }

        return (newMatrix);
    }
}
