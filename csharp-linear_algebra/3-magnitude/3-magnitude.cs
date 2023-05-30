using System;

/// <summary> Vector class </summary>
public class VectorMath
{
    /// <summary> calculates magnitude for 2d/3d vectors </summary>
    public static double Magnitude(double[] vector)
    {
        // Check if the vector is 2D or 3D
        if (vector.Length != 2 && vector.Length != 3)
        {
            return -1;
        }

        // Calculate the magnitude
        double sumOfSquares = 0;
        foreach (double component in vector)
        {
            sumOfSquares += component * component;
        }

        double magnitude = Math.Sqrt(sumOfSquares);

        // Round the magnitude
        magnitude = Math.Round(magnitude, 2);

        return magnitude;
    }
}