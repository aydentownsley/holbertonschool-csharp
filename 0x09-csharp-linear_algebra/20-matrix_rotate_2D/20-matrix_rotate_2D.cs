using System;

class MatrixMath
{
    /// <summary> Rotates matrix by "angle" degress </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (new double[,] {{-1}});

        double[,] result = new double[2, 2];
        double[,] rotate = new double[2, 2] {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    result[i, j] = Math.Round(result[i, j] + (matrix[i, k] * rotate[k, j]), 2);
                }
            }
        }
        return result;
    }
}
