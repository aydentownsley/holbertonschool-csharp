using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> list = new LinkedList<int>();
        for (int x = 0; x < size; x++)
        {
            list.AddLast(x);
            Console.WriteLine(x);
        }
        return list;
    }
}
