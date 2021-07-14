using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine();
        }
        else
        {
            for (int x = array.Length - 1; x >= 0; x--)
            {
                if (x == 0)
                    Console.WriteLine(array[x]);
                else
                    Console.Write(array[x] + " ");
            }
        }
    }
}
