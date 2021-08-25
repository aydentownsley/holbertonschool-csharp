using System;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] inverse = new double[matrix.GetLength(0), matrix.GetLength(1)];

        if (matrix.GetLength(0) != 2)
            return new double[,] {{-1}};

        double det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        inverse[0, 0] = matrix[1, 1] / det;
        inverse[0, 1] = -matrix[0, 1] / det;
        inverse[1, 0] = -matrix[1, 0] / det;
        inverse[1, 1] = matrix[0, 0] / det;

        return inverse;
    }
}
