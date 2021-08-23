using System;

class VectorMath
{
    /// <summary>Dotproduct of two vectors, 2d or 3d</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        int longer_vector = 0;
        double[] result = new double[3];
        double sum = 0;

        if (vector1 == null || vector2 == null)
            return (-1);

        if ((vector1.Length < 2 || vector1.Length > 3) || (vector2.Length < 2 || vector2.Length > 3))
            return (-1);

        if (vector1.Length > vector2.Length || vector1.Length < vector2.Length)
            longer_vector = 1;

        if (longer_vector == 0)
        {
            for (int i = 0; i < vector1.Length; i++)
            {
                vector1[i] *= vector2[i];
            }

            for (int i = 0; i < vector1.Length; i++)
                sum += vector1[i];

            return (sum);
        }

        return (-1);
    }
}
