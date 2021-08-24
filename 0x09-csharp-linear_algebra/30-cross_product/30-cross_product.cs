using System;

class MatrixMath
{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != 3 || vector2.Length != 3)
            return new double[] {-1};

        double[] result = new double[3];

        for (int i = 0; i < 3; i++)
        {
            result[i] = vector1[i] * vector2[(i + 1) % 3] - vector1[(i + 1) % 3] * vector2[i];
        }

        return result;
    }
}
