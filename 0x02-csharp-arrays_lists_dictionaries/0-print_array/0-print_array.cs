using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
           Console.WriteLine("Size cannot be negative");
           return null;
        }

        int x;
        int[] arr = new int[size];
        if (size == 0)
        {
            Console.WriteLine();
            return arr;
        }

        for (x = 0; x < size; x++)
        {
            arr[x] = x;
            if (x == size - 1)
                Console.Write(arr[x]);
            else
                Console.Write(arr[x] + " ");
        }

        Console.WriteLine();
        return arr;
    }
}
