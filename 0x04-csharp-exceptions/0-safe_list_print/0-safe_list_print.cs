using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        try
        {
            for (count = 0; count < n; count++)
            {
                Console.WriteLine(myList[count]);
            }
            return count;
        }
        catch (System.IndexOutOfRangeException)
        {
            return count;
        }
    }
}
