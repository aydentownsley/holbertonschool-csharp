using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        try
        {
            foreach (int element in myList)
            {
                Console.WriteLine(element);
                count++;
            }
            return count;
        }
        catch (System.IndexOutOfRangeException)
        {
            return count;
        }
    }
}
