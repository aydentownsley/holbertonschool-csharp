using System;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1 == null || matrix2 == null)
            return (new double[,] {{-1}});

        if (matrix1.GetLength(1) != matrix2.GetLength(1))
            return (new double[,] {{-1}});

        double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int x = 0; x < result.GetLength(0); x++)
        {
            for (int y = 0; y < result.GetLength(1); y++)
            {
                result[x, y] = 0;
                for (int i = 0; i < matrix1.GetLength(1); i++)
                {
                    result[x, y] += matrix1[x, i] * matrix2[i, y];
                }
            }
        }
        return result;
    }
}
