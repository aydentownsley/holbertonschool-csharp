using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (new double[,] {{-1}});

        if (direction == 'x')
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, 0] = matrix[i, 0] + factor * matrix[i, 1];
            }
            return matrix;
        }
        else if (direction == 'y')
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[i, 1] = matrix[i, 1] + factor * matrix[i, 0];
            }
            return matrix;
        }
        else
            return (new double[,] {{-1}});
    }
}
