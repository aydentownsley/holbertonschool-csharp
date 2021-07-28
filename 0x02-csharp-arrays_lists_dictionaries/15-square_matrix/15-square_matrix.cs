using System;
using System.Collections.Generic;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int[,] newMatrix = new int[myMatrix.GetLength(0), myMatrix.GetLength(1)];
        for (int x = 0; x < myMatrix.GetLength(0); x++)
        {
            for (int y = 0; y < myMatrix.GetLength(1); y++)
            {
                newMatrix[x, y] = myMatrix[x, y] * myMatrix[x, y];
            }
        }

        return newMatrix;
    }
}
