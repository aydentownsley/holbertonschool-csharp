using MyMath;
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] result;

        result = Matrix.Divide(int [,] [2, 2], 2);
        Console.WriteLine(result);
    }
}
