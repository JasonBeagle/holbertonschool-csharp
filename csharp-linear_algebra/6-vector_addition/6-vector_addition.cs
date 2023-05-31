using System;
using System.Collections.Generic;
///<summary> Vector class </summary>
public class VectorMath
{
    /// <summary> adds 2 vectors returning the sum vector </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if ((vector1.Length != 2 && vector1.Length != 3) || vector1.Length != vector2.Length)
        {
            return new double[] { -1 };
        }

        double[] sumVector = new double[vector1.Length];
        for (int i = 0; i < vector1.Length; i++)
        {
            sumVector[i] = vector1[i] + vector2[i];
        }

        return sumVector;
    }
}