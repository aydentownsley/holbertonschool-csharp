using System;

class VectorMath
{
    /// <summary> adding 2D and 3D vectors</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        int longer_vector = 0;
        double[] result = new double[3];

        if (vector1 == null || vector2 == null)
            return (new double[] {-1, -1});

        if ((vector1.Length < 2 || vector1.Length > 3) || (vector2.Length < 2 || vector2.Length > 3))
            return (new double[] {-1, -1});

        if (vector1.Length > vector2.Length || vector1.Length < vector2.Length)
            longer_vector = 1;

        if (longer_vector == 0)
        {
            for (int i = 0; i < vector1.Length; i++)
            {
                vector1[i] += vector2[i];
            }
            return vector1;
        }

        for (int i = 0; i < 2; i++)
        {
               result[i] = vector1[i] + vector2[i];
        }
        result[2] = -1;
        return result;
    }
}
