using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = { {11, 8, 7}, {2, 13, 1}, {4, 0, 17} };

        Console.WriteLine(MatrixMath.Determinant(matrix));
    }
}
