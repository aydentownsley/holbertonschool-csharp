using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[5, 5];

        foreach (int x in array)
        {
            array[x, x] = 0;
        }
        array[2, 2] = 1;
    
        int y = 1;
        foreach (int x in array)
        {
            if (y % 5 == 0)
                Console.WriteLine(x);
            else
                Console.Write(x + " ");
            y++;
        }
    }
}
