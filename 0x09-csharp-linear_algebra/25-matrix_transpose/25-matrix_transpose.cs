using System;

class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            return (new double[,] {});

        double[,] transposed = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                transposed[j, i] = matrix[i, j];
            }
        }

        return transposed;
    }
}
