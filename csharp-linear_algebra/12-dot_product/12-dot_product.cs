using System;
using System.Collections.Generic;
/// <summary> Vector class </summary>
public class VectorMath
{
    /// <summary> returns dot product of 2d or 3d vectors </summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if ((vector1.Length != 2 && vector1.Length != 3) || vector1.Length != vector2.Length)
        {
            return -1;
        }

        double dotProduct = 0;
        for (int i = 0; i < vector1.Length; i++)
        {
            dotProduct += vector1[i] * vector2[i];
        }

        return dotProduct;
    }
}
