using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int count = 0;
        foreach (int item in myLList)
        {
            if (item == value)
                return count;
            count++;
        }
        return -1;
    }
}
