using System;

namespace MyMath
{
    /// <summary>
    /// Matrix Class
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Matrix division
        /// </summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            try
            {
                int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
                for (int x = 0; x < matrix.GetLength(0); x++)
                {
                    for (int y = 0; y < matrix.GetLength(1); y++)
                    {
                        result[x, y] = matrix[x, y] / num;
                    }
                }
                return result;
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            catch (System.NullReferenceException)
            {
                return null;
            }
        }
    }
}
