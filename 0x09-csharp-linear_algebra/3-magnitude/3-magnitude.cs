using System;

/// <summary> part of vetormath operations </summary>
class VectorMath
{
    /// <summary>find lenght of 2d or 3d vector</summary>
    public static double Magnitude(double[] vector)
    {
        double result = 0;


        if (vector == null)
            return (-1);
        if (vector.Length != 2 && vector.Length != 3)
            return (-1);


        if (vector.Length == 2)
            result = Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2));

        if (vector.Length == 3)
            result = Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2));

        return Math.Round(result, 2);
    }
}
