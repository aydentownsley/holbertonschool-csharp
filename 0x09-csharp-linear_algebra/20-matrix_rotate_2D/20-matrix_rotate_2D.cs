﻿using System;

class MatrixMath
{
    /// <summary> Rotates matrix by "angle" degress </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (new double[,] {{-1}});

        double[,] result = new double[2, 2];
        result[0, 0] = Math.Round(matrix[0,0] * Math.Cos(angle) - matrix[0,1] * Math.Sin(angle), 0.00);
        result[0, 1] = Math.Round(matrix[0,0] * Math.Sin(angle) + matrix[0,1] * Math.Cos(angle), 0.00);
        result[1, 0] = Math.Round(matrix[1,0] * Math.Cos(angle) - matrix[1,1] * Math.Sin(angle), 0.00);
        result[1, 1] = Math.Round(matrix[1,0] * Math.Sin(angle) + matrix[1,1] * Math.Cos(angle), 0.00);

        return result;
    }
}
