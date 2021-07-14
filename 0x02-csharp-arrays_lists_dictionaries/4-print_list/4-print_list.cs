using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> newList = new List<int>();

        if (size == 0)
            Console.WriteLine();
        else if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        for (int x = 0; x < size; x++)
        {
            newList.Add(x);
            if (x == size - 1)
                Console.WriteLine(newList[x]);
            else
                Console.Write(newList[x] + " ");
        }

        return newList;
    }
}
