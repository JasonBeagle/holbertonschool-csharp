using System;
using System.Collections.Generic;
/// <summary> Vector class </summary>
public class VectorMath
{
    /// <summary> multiplies vector with a scaler, returns result vector </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        // is vector is 2D or 3D
        if (vector.Length != 2 && vector.Length != 3)
        {
            // return vector containing -1 if not
            return new double[] { -1 };
        }

        // multiply vector by scalar
        double[] resultVector = new double[vector.Length];
        for (int i = 0; i < vector.Length; i++)
        {
            resultVector[i] = vector[i] * scalar;
        }
        // return result
        return resultVector;
    }
}
